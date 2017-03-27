angular.module('WelcomePage', [])
        .controller('WelcomePageController', function ($scope, $window, $http) {

            $scope.test = "Angular test succeeded";

            $scope.redirectToSearchMatch = function () {
                var url = "http://" + $window.location.host + "/Home/SearchMatch";
                $window.location.href = url;
            };
        });