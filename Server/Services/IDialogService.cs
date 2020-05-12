using Server.Events.Dialogs;
using Server.Requests.Dialogs;
using Server.Responses.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    [ServiceContract (CallbackContract = typeof(IDialogServiceCallback))]
    public interface IDialogService
    {
        [OperationContract]
        CreateDialogResponse CreateDialog(CreateDialogRequest request);

        [OperationContract]
        EditDialogResponse EditDialog(EditDialogRequest request);

        [OperationContract]
        DeleteDialogResponse DeleteDialog(DeleteDialogRequest request);

        [OperationContract]
        AddUserToDialogResponse AddUserToDialog(AddUserToDialogRequest request);

        [OperationContract]
        JoinToDialogResponse JoinToDialog(JoinToDialogRequest request);

        [OperationContract]
        UserLeavesFromDialogResponse LeaveFromDialog(UserLeavesFromDialogRequest request);
    }

    public interface IDialogServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnCreatedDialog(CreateDialogEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnDeletedDialog(DeleteDialogEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnEditedDialog(EditDialogEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnUserAdded(AddUserToDialogEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnUserJoined(UserJoinedToDialogEventArgs args);

        [OperationContract(IsOneWay = true)]
        void OnUserLeaves(UserLeavesFromDialogEventArgs args);
    }
}
