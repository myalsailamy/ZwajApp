import { Photo } from './Photo';

export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoURL: string;
    city: string;
    country: string;
    introduction?: string;
    lookingFor?: string;
    interests?: string;
    photos?: Photo[] ;
}
