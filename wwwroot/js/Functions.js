
function calcularDiasVigencia(fechaInicioId, fechaFinId, resultadoId) {
  const inicio = $(fechaInicioId).val();
  const fin = $(fechaFinId).val();

  if (!inicio || !fin) {
    $(resultadoId).val("");
    return;
  }

  const fechaInicio = new Date();
  const fechaFin = new Date(fin);

  const diferenciaMs = fechaFin - fechaInicio;

  if (diferenciaMs < 0) {
    $(resultadoId).val(0);
    return;
  }

  const dias = Math.floor(diferenciaMs / (1000 * 60 * 60 * 24)) + 1;

  $(resultadoId).val(dias);
}

function actualizarBadgeVigencia(inputId, badgeId) {
  const dias = parseInt($(inputId).val()) || 0;
  const badge = $(badgeId);

  badge.removeClass("text-bg-success text-bg-warning text-bg-danger text-bg-secondary");

  if (dias > 5) {
    badge.addClass("text-bg-success").removeClass("d-none").text("Vigente");
  } else if (dias > 1) {
    badge
      .addClass("text-bg-warning")
      .removeClass("d-none")
      .text("Vence pronto");
  } else {
    badge.addClass("text-bg-danger").removeClass("d-none").text("Vencido");
  }
}

function LoadSelect(selectId, data) {
  var categoriaSelect = $(selectId);
  categoriaSelect.empty();
  categoriaSelect.append('<option value="">Seleccione una opción</option>');
  $.each(data, function (i, item) {
    categoriaSelect.append(
      '<option value="' + item.id + '">' + item.descripcion + "</option>",
    );
  });
}

function showToast(message, type = "success", time = 2500) {
  let id = "toast_" + Date.now();
  let toast = `<div id="${id}" class="alert alert-${type} shadow toast-animate mb-2" role="alert">${message}</div>`;
  $("#toastContainer").append(toast);

  setTimeout(() => {
    $("#" + id).fadeOut(300, function () {
      $(this).remove();
    });
  }, time);
}

function formatearMiles(input) {
  let valor = input.value.replace(/\D/g, "");
  input.value = new Intl.NumberFormat("es-CO").format(valor);
}
function togglePwd(inputId, iconId) {
  const input = $("#" + inputId);
  const icon = $("#" + iconId);

  if (input.attr("type") === "password") {
    input.attr("type", "text");
    icon.removeClass("fa-eye").addClass("fa-eye-slash");
  } else {
    input.attr("type", "password");
    icon.removeClass("fa-eye-slash").addClass("fa-eye");
  }
}

function showLoader() {
  $("#globalLoader").removeClass("d-none");
}
function hideLoader() {
  $("#globalLoader").addClass("d-none");
}

function resetForm(formId) {

    const form = $(formId);

    form[0].reset();
    form.find("input[type=hidden]").val("");
    form.find("select").prop("selectedIndex", 0).trigger("change");

    resetValidation(formId);
}

function validateForm(formId) {

    const form = $(formId);

    form.addClass('was-validated');

    const invalid = form.find(':invalid').first();

    if (invalid.length > 0) {
        invalid.focus();
        return false;
    }

    return true;
}
function resetValidation(formId) {

    const form = $(formId);

    form.removeClass('was-validated');
    form.find('.is-invalid').removeClass('is-invalid');
    form.find('.is-valid').removeClass('is-valid');
}

function ChangeStatusBtn(config, btn, nav, edit, remove, cancel, save, form) {
  switch (btn) {
    case "add":
      $(config.btnNav).prop("disabled", nav);
      $(config.edit).prop("disabled", edit);
      $(config.delete).prop("disabled", remove);
      $(config.cancel).prop("disabled", cancel);
      $(config.save).prop("disabled", save);
      $(config.form).prop("disabled", form);
      break;
    case "edit":
      $(config.btnNav).prop("disabled", nav);
      $(config.edit).prop("disabled", edit);
      $(config.delete).prop("disabled", remove);
      $(config.cancel).prop("disabled", cancel);
      $(config.save).prop("disabled", save);
      $(config.form).prop("disabled", form);
      break;
    case "delete":
      $(config.btnNav).prop("disabled", nav);
      $(config.edit).prop("disabled", edit);
      $(config.delete).prop("disabled", remove);
      $(config.cancel).prop("disabled", cancel);
      $(config.save).prop("disabled", save);
      $(config.form).prop("disabled", form);
      break;
    case "cancel":
      $(config.btnNav).prop("disabled", nav);
      $(config.edit).prop("disabled", edit);
      $(config.delete).prop("disabled", remove);
      $(config.cancel).prop("disabled", cancel);
      $(config.save).prop("disabled", save);
      $(config.form).prop("disabled", form);
      break;
    default:
      $(config.btnNav).prop("disabled", nav);
      $(config.edit).prop("disabled", edit);
      $(config.delete).prop("disabled", remove);
      $(config.cancel).prop("disabled", cancel);
      $(config.save).prop("disabled", save);
      $(config.form).prop("disabled", form);
      break;
  }
}

function initAutocomplete(inputId, clearBtnId, dataSource) {
  const $input = inputId;
  const $clearBtn = clearBtnId;

  $input.autocomplete({
    source: dataSource,
    minLength: 1,
    delay: 150,
    select: function (event, ui) {
      $input.val(ui.item.value);
      $clearBtn.removeClass("d-none");
      return false;
    },
  });

  $clearBtn.on("click", function () {
    $input.val("");
    $clearBtn.addClass("d-none");
  });

  $input.on("input", function () {
    if ($input.val().length > 0) {
      $clearBtn.removeClass("d-none");
    } else {
      $clearBtn.addClass("d-none");
    }
  });
}
function formatCurrency(value) {
  const settings = JSON.parse(localStorage.getItem("app_settings"));
  const currency = settings?.currency || "COP";
  const format = settings?.currencyFormat || "symbol";

  return new Intl.NumberFormat("es-CO", {
    style: "currency",
    currency,
    currencyDisplay: format === "code" ? "code" : "symbol",
  }).format(value);
}

function LoadPDF(data, titulo = "Documento") {
  const byteCharacters = atob(data);
  const byteNumbers = new Array(byteCharacters.length);
  for (let i = 0; i < byteCharacters.length; i++) {
    byteNumbers[i] = byteCharacters.charCodeAt(i);
  }
  const byteArray = new Uint8Array(byteNumbers);
  const blob = new Blob([byteArray], { type: "application/pdf" });

  const blobUrl = URL.createObjectURL(blob);

  const faviconElement = $document.querySelector("link[rel*='icon']");
  const faviconHref = faviconElement ? faviconElement.href : "";

  const ventana = window.open("", "_blank");
  if (ventana) {
    ventana.document.write(`
      <html>
        <head>
          <title>${titulo}</title>
          ${faviconHref ? `<link rel="icon" href="${faviconHref}" type="image/x-icon">` : ""}
          <style>
            body, html { margin: 0; height: 100%; }
            iframe { width: 100%; height: 100%; border: none; }
          </style>
        </head>
        <body>
          <iframe src="${blobUrl}"></iframe>
        </body>
      </html>
    `);
    ventana.document.close();
  } else {
    alert(
      "No se pudo abrir una nueva ventana. Verifica si el navegador está bloqueando los pop-ups.",
    );
  }
}

function toggleLoadingState(button, isLoading) {
  $(button).find(".Imprimirtext").toggleClass("d-none", isLoading);
  $(button).find(".spinner-border").toggleClass("d-none", !isLoading);
  $(button).find(".loading-text").toggleClass("d-none", !isLoading);
}

function obtenerIniciales(cadena) {
  if (!cadena || typeof cadena !== "string") return "";

  const palabras = cadena.trim().split(/\s+/);

  if (palabras.length === 1) {
    const palabra = palabras[0];
    return palabra.length >= 2
      ? (palabra[0] + palabra[palabra.length - 1]).toUpperCase()
      : palabra[0].toUpperCase();
  }

  return palabras.map((p) => p[0].toUpperCase()).join("");
}

function showAlert(icon, title, message) {
  swal.fire({
    theme: "auto",
    title: title,
    text: message,
    icon: icon,
  });
}

function showAlertSinBtn(icon, title, message) {
  swal.fire({
    theme: "auto",
    title: title,
    text: message,
    icon: icon,
    showConfirmButton: false,
    timer: 1800,
  });
}
function showAlertError(icon, title, message, fullMessage) {
  Swal.fire({
    title: title,
    html: `
            <p>${message}</p>
            <a id="verMas" style="cursor:pointer;color:blue">ver más..</a>
            <div id="contentvermas" class="d-none" style="text-align:left;max-height:200px;overflow-y:auto;margin-top:10px;">
                <p>${fullMessage}</p>
            </div>
          `,
    icon: icon,
    confirmButtonText: "Cerrar",

    didOpen: () => {
      document.getElementById("verMas").addEventListener("click", function () {
        document.getElementById("contentvermas").classList.remove("d-none");
      });
    },
  });
}
function formatDate(fecha) {
  return moment(fecha).format("DD/MM/YYYY");
}
function formatDateTime(fecha) {
  return moment(fecha).format("LLL");
}
function cargarDatatablePagination(idTabla, tabla) {
  return idTabla.DataTable({
    language: {
      url: "//cdn.datatables.net/plug-ins/2.2.2/i18n/es-ES.json",
      lengthMenu: `Mostrar _MENU_ ${tabla}`,
      zeroRecords: `No se encontraron ${tabla}`,
      emptyTable: `No hay ${tabla} que mostrar`,
      infoEmpty: `Mostrando ${tabla} del 0 al 0 de un total de 0 ${tabla}`,
      infoFiltered: `(filtrado de un total de _MAX_ ${tabla})`,
      search: "Buscar:",
      loadingRecords: "Cargando...",
      info: `Mostrando _START_ a _END_ de _TOTAL_ ${tabla}`,
      paginate: {
        first: "<<",
        last: ">>",
        next: ">",
        previous: "<",
      },
    },
    Response: true,
    searching: false,
    paging: true,
    lengthChange: false,
    processing: true,
    pageLength: 10,
    lengthMenu: [10],
    scrollCollapse: true,
    scrollY: "50vh",
  });
}

function cargarDatatableSinFiltro(idTabla, tabla) {
  return idTabla.DataTable({
    language: {
      url: "//cdn.datatables.net/plug-ins/2.2.2/i18n/es-ES.json",
      lengthMenu: `Mostrar _MENU_ ${tabla}`,
      zeroRecords: `No se encontraron ${tabla}`,
      emptyTable: `No hay ${tabla} que mostrar`,
      infoEmpty: `Mostrando ${tabla} del 0 al 0 de un total de 0 ${tabla}`,
      infoFiltered: `(filtrado de un total de _MAX_ ${tabla})`,
      search: "Buscar:",
      loadingRecords: "Cargando...",
      info: `Mostrando _START_ a _END_ de _TOTAL_ ${tabla}`,
      paginate: {
        first: "<<",
        last: ">>",
        next: ">",
        previous: "<",
      },
    },
    Response: true,
    searching: false,
    paging: false,
    lengthChange: true,
    processing: true,
    pageLength: 10,
    lengthMenu: [10, 25, 50, 100],
    scrollCollapse: true,
    scrollY: "50vh",
  });
}

function cargarDatatable(idTabla, tabla) {
  return idTabla.DataTable({
    language: {
      //url: "//cdn.datatables.net/plug-ins/2.2.2/i18n/es-ES.json",
      lengthMenu: `Mostrar _MENU_ ${tabla}`,
      zeroRecords: `No se encontraron ${tabla}`,
      emptyTable: `No hay ${tabla} que mostrar`,
      infoEmpty: `Mostrando ${tabla} del 0 al 0 de un total de 0 ${tabla}`,
      infoFiltered: `(filtrado de un total de _MAX_ ${tabla})`,
      search: "Buscar:",
      loadingRecords: "Cargando...",
      info: `Mostrando _START_ a _END_ de _TOTAL_ ${tabla}`,
      paginate: {
        first: "<<",
        last: ">>",
        next: ">",
        previous: "<",
      },
    },
    processing: true,
    pageLength: 10,
    lengthMenu: [10, 25, 50, 100],
    scrollCollapse: true,
    scrollY: "70vh",
  });
}

function cargarDatatableExcel(idTabla, tabla, columnas) {
  return idTabla.DataTable({
    dom: "Bfrtip",
    buttons: [
      {
        extend: "excelHtml5",
        exportOptions: {
          columns: columnas,
        },
      },
    ],
    language: {
      url: "//cdn.datatables.net/plug-ins/2.2.2/i18n/es-ES.json",
      lengthMenu: `Mostrar _MENU_ ${tabla}`,
      zeroRecords: `No se encontraron ${tabla}`,
      emptyTable: `no hay ${tabla} que mostrar`,
      infoEmpty: `Mostrando ${tabla} del 0 al 0 de un total de 0 ${tabla}`,
      infoFiltered: `(filtrado de un total de _MAX_ ${tabla})`,
      search: "Buscar:",
      loadingRecords: "Cargando...",
      paginate: {
        first: "<<",
        last: ">>",
        next: ">",
        previous: "<",
      },
    },
    processing: true,
    pageLength: 10,
    lengthMenu: [10, 25, 50, 100],
    scrollCollapse: true,
    scrollY: "50vh",
  });
}

function DatosDeplegables(
  nombre,
  descripcion,
  cant_gigas,
  cant_minutos,
  tabla,
) {
  $.ajax({
    url: '@Url.Action("SetDatosTablas", "Api")',
    type: "POST",
    beforeSend: function () {
      $("#VentanaCarga").modal("show");
    },
    data: {
      nombre: nombre,
      descripcion: descripcion,
      cant_gigas: cant_gigas,
      cant_minutos: cant_minutos,
      tabla: tabla,
    },
    success: function (data) {
      if (data.respuesta === true) {
        showAlert(data.icono, "¡Exito!", data.message);
        setTimeout(function () {
          location.reload();
        }, 1000);
      } else {
        showAlert(data.icono, "¡Error!", data.message);
      }
    },
    complete: function () {
      $("#VentanaCarga").modal("hide");
    },
  });
}
