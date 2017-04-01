angular.module('WelcomePage', [])
        .controller('WelcomePageController', function ($scope, $window, $http) {

            $scope.selectedInterests = [];

            $scope.name = "";

            //Showing / hiding the registration pages:
            $scope.hideFirstRegPage = false;
            $scope.hideSecondRegPage = true;
            $scope.hideThirdRegPage = true;
            $scope.hideInterestButtons = true;

            //User's registration steps continuation:
            $scope.finishedFirstStep = false;
            $scope.finishedSecondsStep = false;
            $scope.finishedThirdStep = false;
            $scope.finishedInterestsStep = false;

            $scope.interestSelected = function (index) {
                $scope.interestButtons[index].isSelected = !$scope.interestButtons[index].isSelected;
            }

            $scope.RegistrationModalTitle = "About you";

            $scope.completeFirstRegStage = function () {

                $scope.hideFirstRegPage = true;
                $scope.hideSecondRegPage = false;
            }

            $scope.completeSecondRegStage = function () {

                $scope.RegistrationModalTitle = "About Your ideal partner";
                $scope.hideSecondRegPage = true;
                $scope.hideThirdRegPage = false;
            }

            $scope.completeThirdRegStage = function () {

                $scope.RegistrationModalTitle = "Your interests";
                $scope.hideThirdRegPage = true;
                $scope.hideInterestButtons = false;
            }

            $scope.completeInterestsRegStage = function () {

                $scope.updateInterests();

                var registrationResponsesUIModel = {
                    'Name': $scope.name,
                    'Month': $scope.selectedMonth,
                    'Day': $scope.selectedDay,
                    'Year': $scope.selectedYear,
                    'Country': $scope.country,
                    'City': $scope.city,
                    'AboutMe': $scope.aboutMe,
                    'Relation': $scope.selectedRelation,
                    'PartnerAgesStart': $scope.agesStart,
                    'PartnerAgesEnd': $scope.agesEnd,
                    'AboutPartner': $scope.aboutPartner,
                    'SelectedInterests': $scope.selectedInterests
                };

                //Register the member with all the responses for the registration form and the interests -
                var url = "http://" + $window.location.host + "/Home/RegisterMember";
                $http({
                    url: url,
                    method: "POST",
                    data: JSON.stringify(registrationResponsesUIModel)
                })
                .then(function () {
                    var url = "http://" + $window.location.host + "/Home/SearchMatch";
                    $window.location.href = url;
                });
            }

            //Put the interests to send in the selectedInterests array :
            $scope.updateInterests = function () {
                for (var i = 0; i < $scope.interestButtons.length; i++) {
                    if ($scope.interestButtons[i].isSelected) {
                        $scope.selectedInterests.push($scope.interestButtons[i]);
                    }
                }
            }

            $scope.openRegistrationModal = function () {
                $("#loginOrRegisterModal").modal("hide");
                $("#registrationModal").modal("show");
            }

            $scope.redirectToSearchMatch = function () {
                $("#loginOrRegisterModal").modal("hide");
                var url = "http://" + $window.location.host + "/Home/SearchMatch";
                $window.location.href = url;
            };

            $scope.interestButtons = [];

            $scope.init = function () {
                $("#loginOrRegisterModal").modal("show");

                var url = "http://" + $window.location.host + "/Home/GetRegistrationOptions";
                $http({
                    url: url,
                    method: "GET"
                })
                .then(function (result) {
                    var interests = result.data.Interests;
                    for (var i = 0; i < interests.length; i++) {
                        $scope.interestButtons.push({
                            text: interests[i],
                            isSelected: false
                        });
                    }

                    $scope.days = result.data.Days;
                    $scope.selectedDay = "1";
                    $scope.months = result.data.Months;
                    $scope.selectedMonth = "January";
                    $scope.years = result.data.Years;
                    $scope.selectedYear = "1980";
                    $scope.relations = result.data.Relations;
                    $scope.selectedRelation = "Man looking for a woman";
                    $scope.ages = result.data.Ages;
                    $scope.agesStart = "20";
                    $scope.agesEnd = "30";

                });
            };

        });