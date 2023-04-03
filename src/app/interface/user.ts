export interface IUser{
    Id?: number
    FirstName: string
    LastName: string
    Email: string
    Password: string
    Favorites?: []
    IsAdmin?: boolean
}