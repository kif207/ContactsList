﻿
angular.module('myContactsApp').service(
    "ContactService",
    function ($http, $q) {
        // Return public API.
        return ({
            getAllContacts: getAllContacts
        });

        function getAllContacts() {
            var request = $http({
                method: "get",
                url: "api/Contact"
            });

            return (request.then(handleSuccess, handleError));
        }

        // Transform the error response, unwrapping the application dta from
        // the API response payload.
        function handleError(response) {

            // The API response from the server should be returned in a
            // nomralized format. However, if the request was not handled by the
            // server (or what not handles properly - ex. server error), then we
            // may have to normalize it on our end, as best we can.
            if (
                !angular.isObject(response.data) ||
                !response.data.Message
                ) {

                return ($q.reject("An unknown error occurred."));

            }

            // Otherwise, use expected error message.
            return ($q.reject(response.data.Message));

        }

        // I transform the successful response, unwrapping the application data
        // from the API response payload.
        function handleSuccess(response) {

            return (response.data);

        }

    });