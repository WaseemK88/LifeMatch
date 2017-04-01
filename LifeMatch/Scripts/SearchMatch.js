var searchMatch = angular.module('searchMatch', []);

searchMatch.controller('SearchMatchController', function ($scope, $window, UserService) {

    $scope.getUserInfo = function () {

        UserService.getUserInfo()
            .then(function (response) {

                alert(response.data);

            }, function (error) {
                //TODO - handle error
            });
    }
});