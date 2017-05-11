var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('WebApiServerDemo');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);