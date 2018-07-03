// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    var $loading = $('#loadingDiv').hide();

    $(document)
        .ajaxStart(function () {
            $loading.show();
            $(".css-checkbox").prop('disabled', true);
            $(".css-label").prop('disabled', true);
            $(".css-checkbox").attr('disabled');
            $(".css-label").attr('disabled');
        })
        .ajaxStop(function () {
            $loading.hide();
            $(".css-checkbox").prop('disabled', false);
            $(".css-label").prop('disabled', false);
            $(".css-checkbox").removeAttr('disabled');
            $(".css-label").removeAttr('disabled');
        });

    //LoadServicePanels("AKS");
    //LoadServicePanels("AppService");
    //LoadServicePanels("ServiceFabric");

    $(".css-checkbox").change(function () {
        var serviceValue = $(this).val();

        LoadServicePanels(serviceValue);
    });
});

function LoadServicePanels(serviceValue) {
    GetShowPanel("General", "pnlGeneral", serviceValue);
    GetShowPanel("Hosting", "pnlHosting", serviceValue);
    GetShowPanel("DevOps", "pnlDevOps", serviceValue);
    GetShowPanel("Scalability", "pnlScalability", serviceValue);
    GetShowPanel("Availability", "pnlAvailability", serviceValue);
    GetShowPanel("Security", "pnlSecurity", serviceValue);
    GetShowPanel("Discovery", "pnlDiscovery", serviceValue);
    GetShowPanel("Integration", "pnlIntegration", serviceValue);
    GetShowPanel("CostSupport", "pnlCostSupport", serviceValue);
}

function GetShowPanel(section, panel, serviceValue) {
    $.ajax({
        type: "GET",
        url: '/Home/Get' + section + 'Name?service=' + serviceValue,
        dataType: "html",
        success: function (panelName) {
            panelName = panelName.replace(/^"(.+(?="$))"$/, '$1'); //Quick workaround to remove the double quotes

            if (panelName) {
                if ($("#" + panelName).length) {
                    //it exist
                    $("#" + panelName).remove();
                }
                else {
                    $.ajax({
                        type: "GET",
                        url: '/Home/Get' + section + '?service=' + serviceValue,
                        dataType: "html",
                        success: function (result) {
                            if (result) {
                                $("#" + panel).append(result);
                            }
                        },
                        error: function (xhr, ajaxOptions, thrownError) { alert('ERROR appending in ' + panel + ': ' + thrownError); }
                    })
                }
            }
        },
        error: function (xhr, ajaxOptions, thrownError) { alert('ERROR checking name in ' + panel + ': ' + thrownError); }
    });
}