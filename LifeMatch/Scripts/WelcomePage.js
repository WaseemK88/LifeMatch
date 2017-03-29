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

            $scope.interestSelected = function (index) {
                $scope.interestButtons[index].isSelected = !$scope.interestButtons[index].isSelected;
            }

            $scope.redirectToSearchMatch = function () {
                var url = "http://" + $window.location.host + "/Home/SearchMatch";
                $window.location.href = url;
            };


            $scope.sendInterests = function () {
                var selectedInterests = [];
                for (var i = 0; i < $scope.interestButtons.length; i++) {
                    if ($scope.interestButtons[i].isSelected) {
                        selectedInterests.push($scope.interestButtons[i]);
                    }
                }
                alert(JSON.stringify(selectedInterests));

                var url = "http://" + $window.location.host + "/Home/SaveInterestsAsync";
                $http({
                    url: url,
                    method: "POST",
                    data: JSON.stringify(selectedInterests)
                })
                .then(function (interests) {
                    alert(interests);
                    });
            };
        });