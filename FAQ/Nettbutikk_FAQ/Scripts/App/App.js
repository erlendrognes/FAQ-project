var App = angular.module("App", ['ui.bootstrap', 'ngRoute']);

App.config(function ($routeProvider) {

    $routeProvider
        .when('/', {
            controller: 'FaqController',
            templateUrl: 'partials/main.html'
        })
        .when('/askQuestion', {
            controller: 'QuestionController',
            templateUrl: 'partials/askQuestion.html'
        })
        .when('/faq/category/:id', {
            controller: 'CategoryController',
            templateUrl: 'partials/categories.html'
        })
        .when('/faq', {
            controller: 'FaqController',
            templateUrl: 'partials/faqs.html'
        })
        .when('/ask/asked', {
            controller: 'QuestionController',
            templateUrl: 'partials/askedQuestions.html'
        })
        .when('/topfive', {
            controller: 'FaqController',
            templateUrl: 'partials/topFiveFaqs.html'
        })
        .otherwise({
            redirectTo: '/'
        });

});