class User {
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
}

class Generic<T>{
    members: T[];
    numberOfMembers: number;

    constructor(members: T[], numberOfMembers: number) {
        this.members = members;
        this.numberOfMembers = numberOfMembers;
    }

    filter = function (age: number){
        for(let member of this.members){
            if(member.age < age)
                return false;
            return  true;
        }
    }
}

const user1 = new User("a","a",20,false);
const user2 = new User("b","b",17,false);
const user3 = new User("c","c",25,true);

const usersArray: User[] = [user1, user2, user3];

let genericInstance = new Generic<User>(usersArray, 3);

console.log(genericInstance.filter(18));
