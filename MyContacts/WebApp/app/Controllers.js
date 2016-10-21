(function () {
    'use strict';
    var app = angular.module('myContactsApp', []);

    app.controller('ContactsController', function ($scope, ContactService) {

        $scope.error = "";
        $scope.contacts = {};
        
        loadContacts();

        function loadContacts()
        {
            ContactService.getAllContacts()
                .then(
                        function (data) { $scope.contacts = data; },
                        function (error) { $scope.error = error; }
                      );

        }
    });
})();
