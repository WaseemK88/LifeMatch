angular.module('SearchMatch', [])
        .controller('SearchMatchController', function ($scope, $http, $window) {

            $scope.showMessage = false;
            $scope.name = "";

            $scope.genders = ["Male", "Female"];
            $scope.selectedGender = "Male";

            $scope.days = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"];
            $scope.selectedDay = "1";
            $scope.months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
            $scope.selectedMonth = "January";
            $scope.years = ["1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997"];
            $scope.selectedYear = "1980";

            $scope.relations = ["Man looking for a woman", "Woman looking for a man", "Man looking for a man", "Woman looking for a woman"];
            $scope.selectedRelation = "Man looking for a woman";

            $scope.ages = ["20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70"];
            $scope.agesStart = "20";
            $scope.agesEnd = "30";

            $scope.register = function () {

                var url = "http://" + $window.location.host + "/Home/RegisterMember";

                var registrationResponsesUIModel = {
                    'Name': $scope.name,
                    'Gender': $scope.selectedGender,
                    'Month': $scope.selectedMonth,
                    'Day': $scope.selectedDay,
                    'Year': $scope.selectedYear,
                    'Country': $scope.country,
                    'City': $scope.city,
                    'AboutMe': $scope.aboutMe,
                    'Relation': $scope.selectedRelation,
                    'PartnerAgesStart': $scope.agesStart,
                    'PartnerAgesEnd': $scope.agesEnd,
                    'AboutPartner': $scope.aboutPartner
                };

                $http({
                    url: url,
                    method: "POST",
                    data: registrationResponsesUIModel
                })
                .then(function (member) {
                    $scope.FirstName = member.data.FirstName;
                    $scope.LastName = member.data.LastName;
                    $scope.showMessage = true;
                });
            };
        });
