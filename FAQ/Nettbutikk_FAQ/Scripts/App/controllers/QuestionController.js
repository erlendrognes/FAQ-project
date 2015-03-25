angular.module('App').controller("QuestionController", function ($scope, $http, $location) {

    $http.get('../../api/question/').
    success(function (data) {
        $scope.asked = data;
    }).
    error(function (data, status) {
    });

    $scope.askQuestion = function () {
        var ques = {
            title: $scope.title,
            question: $scope.question,
            name: $scope.name,
            email: $scope.email
        }


        $http.post('../../api/question/', ques).
        success(function () {
            $location.path('/askedquestionsurlyolo');
        }).
        error(function () {
        });
    };
});