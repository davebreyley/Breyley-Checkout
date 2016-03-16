var LandingPageController = function($scope) {
    //need to define our catalog as an collection of skus
    //  Item
    //  Price
    //  Offer

    // $scope.models = {
        
    // };

    $scope.ScanItem = function () {
        /*
            need to make call to API passing in Scaned SKU
            Function will test SKU error if sku does not exist in catalog
            if sku does exist, we look at existing lines in cart
                if sku is found in cart increment quantity and test for offer
        */
    };

}

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
LandingPageController.$inject = ['$scope'];