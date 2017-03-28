angular.module('WelcomePage', [])
        .controller('WelcomePageController', function ($scope, $window, $http) {

            $scope.genders = ["Man looking for a woman", "Woman looking for a man", "Man looking for a man", "Woman looking for a woman"];
            $scope.selectedGender = "Man looking for a woman";

            $scope.ages = ["20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70"];
            $scope.agesStart = "20";
            $scope.agesEnd = "30";

            $scope.redirectToSearchMatch = function () {
                var url = "http://" + $window.location.host + "/Home/SearchMatch";
                $window.location.href = url;
            };
        });