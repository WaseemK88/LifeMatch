var searchMatch = angular.module('searchMatch', []);

searchMatch.controller('SearchMatchController', function ($scope, $window, UserService) {

    $scope.name = "";
    $scope.email = "";
    $scope.password = "";
    $scope.dateOfBirth = "";
    $scope.country = "";
    $scope.city = "";
    $scope.aboutUser = "";
    $scope.gender = "";
    $scope.partnerGender = "";
    $scope.partnerAgeStart = "";
    $scope.partnerAgeEnd = "";
    $scope.aboutPartner = "";

    $scope.initialize = function () {

        UserService.getUserInfo()
            .then(function (response) {

                $scope.name = response.data.UserName;
                $scope.email = response.data.Email;
                $scope.password = response.data.Password;
                $scope.yearOfBirth = response.data.YearOfBirth;
                $scope.country = response.data.Country;
                $scope.city = response.data.City;
                $scope.aboutUser = response.data.AboutMember;
                $scope.gender = response.data.Gender;
                $scope.partnerGender = response.data.PartnerGender;
                $scope.partnerAgeStart = response.data.PartnerAgesStart;
                $scope.partnerAgeEnd = response.data.PartnerAgesEnd;
                $scope.aboutPartner = response.data.AboutPartner;

            }, function (error) {
                //TODO - handle error
            });
    }
});