angular.module('SearchMatch', [])
        .controller('SearchMatchController', function ($scope, $http) {

            $scope.ButtonTitle = {
                Text: "Click to call the server"
            }

            $scope.showMessage = false;

            $scope.callServer = function () {
                $http.get("HelloFromServer")
                .then(function (member) {
                    $scope.FirstName = member.data.FirstName;
                    $scope.LastName = member.data.LastName;
                    $scope.showMessage = true;
                    });
            };
        });
