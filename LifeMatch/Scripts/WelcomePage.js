angular.module('WelcomePage', [])
        .controller('WelcomePageController', function ($scope, $window, $http) {

            $scope.interestButtons = [
                { id: 1, text: "Aircraft Spotting", isSelected: false },
                { id: 2, text: "Airbrushing", isSelected: false },
                { id: 3, text: "Acting", isSelected: false },
                { id: 4, text: "Airsofting", isSelected: false },
                { id: 5, text: "Aeromodeling", isSelected: false },
                { id: 6, text: "Amateur Astronomy", isSelected: false },
                { id: 7, text: "Amateur Radio", isSelected: false },
                { id: 8, text: "Animals/pets/dogs", isSelected: false },
                { id: 9, text: "Archery", isSelected: false },
                { id: 10, text: "Arts", isSelected: false },
                { id: 11, text: "Aquarium", isSelected: false },
                { id: 12, text: "Astrology", isSelected: false },
                { id: 13, text: "Astronomy", isSelected: false },
                { id: 14, text: "Backgammon", isSelected: false },
                { id: 15, text: "Badminton", isSelected: false },
                { id: 16, text: "Baseball", isSelected: false },
                { id: 17, text: "Base Jumping", isSelected: false },
                { id: 18, text: "Basketball", isSelected: false },
                { id: 19, text: "Beach/Sun tanning", isSelected: false },
                { id: 20, text: "Beachcombing", isSelected: false },
                { id: 21, text: "Beadwork", isSelected: false },
                { id: 22, text: "Beatboxing", isSelected: false },
                { id: 23, text: "Bicycling", isSelected: false },
                { id: 24, text: "Bird watching", isSelected: false },
                { id: 25, text: "Birding", isSelected: false },
                { id: 26, text: "BMX", isSelected: false },
                { id: 27, text: "Blacksmithing", isSelected: false },
                { id: 28, text: "Blogging", isSelected: false },
                { id: 29, text: "BoardGames", isSelected: false },
                { id: 30, text: "Boating", isSelected: false },
                { id: 31, text: "Body Building", isSelected: false },
                { id: 32, text: "Bonsai Tree", isSelected: false },
                { id: 33, text: "Bookbinding", isSelected: false },
                { id: 34, text: "Bowling", isSelected: false },
                { id: 35, text: "Brewing Beer", isSelected: false },
                { id: 36, text: "Bridge Building", isSelected: false },
                { id: 37, text: "Cake Decorating", isSelected: false },
                { id: 38, text: "Cartooning", isSelected: false },
                { id: 39, text: "Casino Gambling", isSelected: false },
                { id: 40, text: "Cave Diving", isSelected: false },
                { id: 41, text: "Cheerleading", isSelected: false },
                { id: 42, text: "Chess", isSelected: false },
                { id: 43, text: "Church/church activities", isSelected: false },
                { id: 44, text: "Cigar Smoking", isSelected: false },
                { id: 45, text: "Collecting", isSelected: false },
                { id: 46, text: "Coin Collecting", isSelected: false },
                { id: 47, text: "Computer activities", isSelected: false },
                { id: 48, text: "Conworlding", isSelected: false },
                { id: 49, text: "Dancing", isSelected: false },
                { id: 50, text: "Dolls", isSelected: false },
                { id: 51, text: "Fishing", isSelected: false },
                { id: 52, text: "Games", isSelected: false },
                { id: 53, text: "Golf", isSelected: false },
                { id: 54, text: "Gun Collecting", isSelected: false },
                { id: 55, text: "Home Repair", isSelected: false },
                { id: 56, text: "Hunting", isSelected: false },
                { id: 57, text: "Internet", isSelected: false },
                { id: 58, text: "Inventing", isSelected: false },
                { id: 59, text: "Jewelry Making", isSelected: false },
                { id: 60, text: "Kites", isSelected: false },
                { id: 61, text: "Magic", isSelected: false },
                { id: 62, text: "Martial Arts", isSelected: false },
                { id: 63, text: "Models", isSelected: false }
            ];

            $scope.selectedInterests = [];

            $scope.name = "";

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

                alert("calling server");
                //Register the member with all the responses for the registration form and the interests -
                var url = "http://" + $window.location.host + "/Home/RegisterMember";
                $http({
                    url: url,
                    method: "POST",
                    data: JSON.stringify(registrationResponsesUIModel)
                })
                .then(function (interests) {
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
                alert(JSON.stringify($scope.selectedInterests));
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

            $scope.init = function () {
                $("#loginOrRegisterModal").modal("show");
            };

        });