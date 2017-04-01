searchMatch.service('UserService', function ($http, $window) {

    var url = "http://" + $window.location.host + "/Home/GetUserInfo";

    this.getUserInfo = function () {
        return $http.get(url);
    };

});