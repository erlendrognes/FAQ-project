angular.module('App').controller("FaqController", function ($scope, $http, $route) {

    function getAll() {
        $http.get('../../api/Faq/').
        success(function (data) {
            $scope.faqs = data;
            $scope.loading = false;
            $scope.allfaq = true;
        }).
        error(function (data, status) {

        });
    };

    $scope.loading = true;
    getAll();

    $scope.greaterThan = function (prop, val) {
        return function (item) {
            if (item[prop] > val) return true;
        }
    };

    $scope.updateFrequency = function (id) {

        $http.post('../../api/Faq/' + id).
        success(function (data) {
            $scope.updatefreq = data;
            $route.reload();
        }).
        error(function (data) {
        });
    };

});


