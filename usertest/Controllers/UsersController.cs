
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
[EnableCors("CorsPolicy")]
public class UsersController : Controller
{

    private List<Users>? _users;

    public UsersController(){
        _users = new List<Users>();
        _users.Add(new Users{Id=1,Name="Dragan"});
        _users.Add(new Users{Id=2,Name="Josip"});
        _users.Add(new Users{Id=3,Name="Ivan"});
        _users.Add(new Users{Id=4,Name="Gordan"});
    }

    [HttpGet]
    public ActionResult GetData()
    {
        
       
        return Json(_users);
        
    }

    [HttpDelete]
     public ActionResult DeleteUser(int id)
     {
        

        if(_users == null)
        _users = new List<Users>();
        _users.Add(new Users{Id=1,Name="Dragan"});
        _users.Add(new Users{Id=2,Name="Josip"});
        _users.Add(new Users{Id=3,Name="Ivan"});
        _users.Add(new Users{Id=4,Name="Gordan"});
    
         _users.RemoveAll(u => u.Id == id);
         return Json(_users);
        
     }

    [EnableCors]
    [HttpPut]
    public ActionResult UpdateUser(int id, [FromBody] Users user)
    {

        
         if(_users == null)
         _users = new List<Users>();
         _users.Add(new Users{Id=1,Name="Dragan"});
         _users.Add(new Users{Id=2,Name="Josip"});
         _users.Add(new Users{Id=3,Name="Ivan"});
         _users.Add(new Users{Id=4,Name="Gordan"});

        foreach (var useri in _users)
        {
            if(useri.Id == id){
                useri.Name = user.Name;
                return Ok(new { message = "User updated successfully", _users });
            }
        }
        
            return BadRequest(new { message = "Invalid user id" });
        

        // var targetUser = _users.FirstOrDefault(u => u.Id == id);

        // if(targetUser == null)
        //     return NotFound(new { message = "User not found" });

        // // Rename user
        // targetUser.Name = user.Name;

        
        
    }
     




}