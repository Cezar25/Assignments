class User{
    private email: string;
    private password: string;
    private age: number;
    public hasPrivateProfile: boolean;

    constructor(email: string, password: string, age: number, hasPrivateProfile: boolean) {
        this.email = email;
        this.password = password;
        this.age = age;
        this.hasPrivateProfile = hasPrivateProfile;
    }

    displayIfOldEnought(requiredAge: number){
        if(this.age >= requiredAge){
            console.log(`User: ${this.email} age: ${this.age}`);
        }
    }

    //arrow functions(as properties)

    logUserInfo = () => console.log(`Email : ${this.email} password: ${this.password}
                                     age: ${this.age} has private profile: ${this.hasPrivateProfile}`);

    updateEmail = (newEmail: string) => {
        if(this.email == newEmail)
            return;
        this.email = newEmail;
    }

}