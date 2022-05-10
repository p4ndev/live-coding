import HttpClient from "../provider/HttpClient";

const ActivityService = {

    SaveEntranceAsync : (email : string) => HttpClient.put(
        "/activity", email,
        { headers: { 'Content-Type': 'application/json' } }
    ),

    SaveExitAsync : (email : string) => HttpClient.delete(
        "/activity", {
            data: email,
            headers: { 'Content-Type': 'application/json' }
        }
    ),

    RetrieveAsync : (email : string) => HttpClient.get(
        "/activity?email=" + email
    )

}

export default ActivityService;