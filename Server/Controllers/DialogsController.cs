using Server.Data;
using Server.Requests.Dialogs;
using Server.Responses.Dialogs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class DialogsController : Controller
    {
        public DialogsController(DatabaseContext context) : base(context)
        {
        }

        public CreateDialogResponse CreateDialog(CreateDialogRequest request)
        {
            try
            {
                HashSet<User> dialogUsers = new HashSet<User>(request.Users.Length);
                foreach (Guid userId in request.Users)
                    dialogUsers.Add(Context.Users.Find(userId));

                Dialog dialog = Context.Dialogs.Add(new Dialog(request.Name, dialogUsers));
                return new CreateDialogResponse(DialogResponseId.Successfully, dialog.ToDto());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new CreateDialogResponse(DialogResponseId.ServerException);
            }
        }

        public EditDialogResponse EditDialog(EditDialogRequest request)
        {
            try
            {
                Dialog dialog = Context.Dialogs.Find(request.DialogId);
                dialog.Name = request.EditedName;
                Context.Entry(dialog).State = EntityState.Modified;
                Context.SaveChanges();
                return new EditDialogResponse(DialogResponseId.Successfully, dialog.ToDto());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new EditDialogResponse(DialogResponseId.ServerException);
            }
        }

        public DeleteDialogResponse DeleteDialog(DeleteDialogRequest request)
        {
            try
            {
                Dialog dialog = Context.Dialogs.Find(request.DialogId);
                if (dialog == null)
                    return new DeleteDialogResponse(DialogResponseId.DialogNotExist);

                Context.Dialogs.Remove(dialog);
                return new DeleteDialogResponse(DialogResponseId.Successfully);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new DeleteDialogResponse(DialogResponseId.ServerException);
            }
        }

        public AddUserToDialogResponse AddUserToDialog(AddUserToDialogRequest request)
        {
            try
            {
                Dialog dialog = Context.Dialogs.Find(request.DialogId);
                User user = Context.Users.Find(request.UserId);
                dialog.Users.Add(user);
                Context.Entry(dialog).State = EntityState.Modified;
                Context.SaveChanges();
                return new AddUserToDialogResponse(DialogResponseId.Successfully, user.ToDto());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new AddUserToDialogResponse(DialogResponseId.ServerException);
            }
        }
    }
}
