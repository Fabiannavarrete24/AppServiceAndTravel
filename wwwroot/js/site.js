function showSuccess(title, message, detail = "") {
  showNotification({
    type: "success",
    title: title,
    message: message,
    detail: detail,
  });
}

function showError(title, message, detail = "") {
  showNotification({
    type: "error",
    title: title,
    message: message,
    detail: detail,
  });
}

function showWarning(title, message, detail = "") {
  showNotification({
    type: "warning",
    title: title,
    message: message,
    detail: detail,
  });
}

function showInfo(title, message, detail = "") {
  showNotification({
    type: "info",
    title: title,
    message: message,
    detail: detail,
  });
}

function showNotification(config) {
  return new Promise((resolve) => {
    const cfg = {
      type: config.type || "info",
      title: config.title || "",
      message: config.message || "",
      detail: config.detail || "",
      autoClose: config.autoClose || false,
      timer: config.timer || 3000,
      callback: config.callback || null,
      confirmText: config.confirmText || "Aceptar",
      cancelText: config.cancelText || "Cancelar",

      showCancelButton: config.showCancelButton || false,
    };

    const icon = $("#notificationIcon");

    icon.removeClass();

    switch (cfg.type) {
      case "success":
        icon.addClass(
          "fa-solid fa-circle-check text-success notification-icon",
        );

        break;

      case "error":
        icon.addClass("fa-solid fa-circle-xmark text-danger notification-icon");

        break;

      case "warning":
        icon.addClass(
          "fa-solid fa-triangle-exclamation text-warning notification-icon",
        );

        break;

      case "info":
        icon.addClass("fa-solid fa-circle-info text-primary notification-icon");

        break;
    }

    $("#notificationTitle").html(cfg.title);

    $("#notificationMessage").html(cfg.message);

    $("#notificationContent").val(cfg.detail);

    $("#btnNotificationOk").text(cfg.confirmText);

    $("#btnNotificationCancel").text(cfg.cancelText);

    if (cfg.showCancelButton) $("#btnNotificationCancel").removeClass("d-none");
    else $("#btnNotificationCancel").addClass("d-none");

    $("#appNotification").removeClass("d-none");

    $("#btnNotificationOk")
      .off("click")
      .on("click", function () {
        closeNotification();

        resolve({
          isConfirmed: true,
          isDismissed: false,
        });
      });

    $("#btnNotificationCancel")
      .off("click")
      .on("click", function () {
        closeNotification();

        resolve({
          isConfirmed: false,
          isDismissed: true,
        });
      });

    if (cfg.detail && cfg.detail.length > 0) $("#btnVerDetalle").show();
    else $("#btnVerDetalle").hide();

    $("#notificationDetail").addClass("d-none");

    $("#appNotification").removeClass("d-none");

    if (cfg.autoClose) {
      setTimeout(() => {
        closeNotification();

        if (cfg.callback) cfg.callback();
      }, cfg.timer);
    }
  });
}
