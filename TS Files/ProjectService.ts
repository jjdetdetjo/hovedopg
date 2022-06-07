getAllTickets = () => {

    var url = "/Project/GetAllTickets";

    var promise: ng.IHttpPromise<definitions.HappyFox.Tickets[]>;

    promise = this.$http.get(url);

    return promise;

}
