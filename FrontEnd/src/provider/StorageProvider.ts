
const StorageProvider = {

    GetEmail(){
        return localStorage.getItem("cynet_email") ?? "";
    },

    SetEmail(value: string){
        localStorage.setItem("cynet_email", value);
    }

}

export default StorageProvider;