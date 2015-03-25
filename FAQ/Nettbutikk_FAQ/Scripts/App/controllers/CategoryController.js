angular.module('App').controller("CategoryController", function ($scope, $http, $routeParams, $route) {

    $http.get('../../api/Faq/' + $routeParams.id).
    success(function (data) {

        $scope.faqsByCat = data;
        $scope.categoryName = data[0].catname;
        console.log($scope.categoryName);
    }).
    error(function (data, status) {
    });

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