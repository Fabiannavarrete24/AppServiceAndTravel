class TableManager {

    constructor(config) {
        this.url = config.url;
        this.tableId = config.tableId;
        this.paginationId = config.paginationId;
        this.infoId = config.infoId;
        this.filters = config.filters || {};
        this.pageSize = config.pageSize || 10;
        this.renderTable = config.renderTable;
        this.beforeSend = config.beforeSend || null;
        this.onComplete = config.onComplete || null;
        this.onSuccess = config.onSuccess || null;
        this.onError = config.onError || null;
        this.filterDelay = config.filterDelay || 500;
        this.currentPage = 1;
        this.currentData = [];
        this.currentPagination = {};
        this.initFilters();
    }

    initFilters() {

        Object.entries(this.filters).forEach(([key, selector]) => {
            $(selector).on('input change', () => {
                clearTimeout(this.filterTimeout);
                this.filterTimeout = setTimeout(() => {
                    this.load(1);
                }, this.filterDelay);
            });
        });

    }

    getFilters() {

        let data = {};
        Object.keys(this.filters).forEach(key => {
            let selector = this.filters[key];
            data[key] = $(selector).val() || "";
        });
        return data;

    }

    load(page = 1) {
        this.currentPage = page;
        let data = {
            ...this.getFilters(),
            page: page,
            pageSize: this.pageSize
        };
        if (this.beforeSend)
            this.beforeSend();

        $.ajax({
            url: this.url,
            type: "GET",
            data: data,
            success: (response) => {
                if (!response.success) {
                    showAlert("error","",response.message || "Error al cargar datos");
                    return;
                }
                this.currentData = response.data;
                this.currentPagination = response.pagination;
                this.renderTable(response.data);
                this.renderPagination(response.pagination);
                this.renderInfo(response.pagination,response.data.length);

                if (this.onSuccess)
                    this.onSuccess(response);
            },
            error: (error) => {
                showAlert("error","",error.responseJSON?.message || "Error en la petición");
                if (this.onError)
                    this.onError(error);
            },
            complete: () => {
                if (this.onComplete)
                    this.onComplete();
            }
        });
    }

    renderInfo(pagination, currentCount) {

        let container = $(this.infoId);
        if (!pagination || currentCount === 0) {
            container.text("No hay registros");
            return;
        }

        let start = ((pagination.page - 1) * pagination.pageSize) + 1;
        let end = start + currentCount - 1;
        container.text(`Mostrando ${start} a ${end} de ${pagination.total} registros`);
    }

    renderPagination(pagination) {

        let container = $(this.paginationId);
        container.empty();
        if (!pagination || pagination.totalPages === 0)
            return;

        let page = pagination.page;
        let totalPages = pagination.totalPages;
        container.append(`
            <button
                class="btn btn-outline-primary ${page === 1 ? 'disabled' : ''}"
                ${page === 1 ? 'disabled' : ''}
                data-page="${page - 1}">
                ←
            </button>
        `);

        for (let i = 1; i <= totalPages; i++) {
            container.append(`
                <button
                    class="btn ${i === page ? 'btn-primary' : 'btn-outline-primary'}"
                    data-page="${i}">
                    ${i}
                </button>
            `);
        }

        container.append(`
            <button
                class="btn btn-outline-primary ${page === totalPages ? 'disabled' : ''}"
                ${page === totalPages ? 'disabled' : ''}
                data-page="${page + 1}">
                →
            </button>
        `);

        container.find("button").on("click", (e) => {
            let newPage = $(e.currentTarget).data("page");
            this.load(newPage);
        });
    }

    reload() {
        this.load(this.currentPage);
    }
}