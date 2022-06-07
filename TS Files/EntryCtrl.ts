$scope.IsHappyFoxSelected = () => {

    return $scope.entryDraft.ticket != undefined && !$scope.entryDraft.project.isADOProject;

}

$scope.BCForecast = () => {

    return this.bcForecast($scope);

}

$scope.BCForecastColor = () => {

    let bcForecast = this.bcForecast($scope);

    if (bcForecast > 0) {

        return "Green";

    } else if (bcForecast < 0) {

        return "Red"

    } else {

        return "Gray";

    }

}

 

private bcForecast($scope: IEntryScope): number {

    return $scope.entryDraft.ticket.Estimate - $scope.entryDraft.ticket.TimeSpent;

}
