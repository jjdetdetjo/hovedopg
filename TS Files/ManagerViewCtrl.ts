/*public static $inject = ['$scope', 'managerViewService',*/ 'projectService',/* 'loadingService', '$filter'];*/

 

private projectService: projects.IProjectService,



    $scope.tickets = [];



$scope.getRemainingTicketHours = (name: string) => {

    return this.getTicketHours(name);

}



this.getTickets();

 

private getTickets = () => {

    this.projectService.getAllTickets().then((resp) => {

        this.$scope.tickets = [];

        this.$scope.tickets = resp.data;

    })

}

 

        private getTicketHours = (name: string) => {

    let hours = 0;

    if (this.$scope.tickets != null && this.$scope.tickets.length > 0) {

        for (let t of this.$scope.tickets) {

            if (t.Assignee == name) {

                let timeLeft = t.Estimate - t.TimeSpent;

                if (timeLeft > 0) {

                    hours = hours + timeLeft;

                }

            }

        }

    }

    return hours;

}
