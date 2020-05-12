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
            catch (Exception e)
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
                if (dialog.Users.SingleOrDefault(u => u.Id == request.UserId) != null)
                    return new AddUserToDialogResponse(DialogResponseId.UserAlreadyInDialog);

                User user = Context.Users.Find(request.UserId);
                dialog.Users.Add(user);
                Context.Entry(dialog).State = EntityState.Modified;
                Context.SaveChanges();
                return new AddUserToDialogResponse(DialogResponseId.Successfully, user.ToDto());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new AddUserToDialogResponse(DialogResponseId.ServerException);
            }
        }

        public JoinToDialogResponse JoinToDialog(JoinToDialogRequest request)
        {
            try
            {
                Dialog dialog = Context.Dialogs.Find(request.DialogId);
                if (dialog.Users.SingleOrDefault(u => u.Id == request.Id) != null)
                    return new JoinToDialogResponse(DialogResponseId.UserAlreadyInDialog);

                User user = Context.Users.Find(request.Id);
                dialog.Users.Add(user);
                Context.Entry(dialog).State = EntityState.Modified;
                Context.SaveChanges();
                return new JoinToDialogResponse(DialogResponseId.Successfully, user.ToDto());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new JoinToDialogResponse(DialogResponseId.ServerException);
            }
        }

        public UserLeavesFromDialogResponse LeaveFromDialog(UserLeavesFromDialogRequest request)
        {
            try
            {
                Dialog dialog = Context.Dialogs.Find(request.DialogId);
                if (dialog.Users.SingleOrDefault(u => u.Id == request.Id) == null)
                    return new UserLeavesFromDialogResponse(DialogResponseId.UserNotExist);

                User user = Context.Users.Find(request.Id);
                dialog.Users.Remove(user);
                Context.Entry(dialog).State = EntityState.Modified;
                Context.SaveChanges();
                return new UserLeavesFromDialogResponse(DialogResponseId.Successfully, user.ToDto());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new UserLeavesFromDialogResponse(DialogResponseId.ServerException);
            }
        }
    }
}
