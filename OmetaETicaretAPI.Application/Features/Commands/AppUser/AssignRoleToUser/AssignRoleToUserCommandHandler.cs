using MediatR;
using OmetaETicaretAPI.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaETicaretAPI.Application.Features.Commands.AppUser.AssignRoleToUser
{
    public class AssignRoleToUserCommandHandler : IRequestHandler <AssignRoleToUserCommandRequest, AssignRoleToUserCommandResponse>
    {
        readonly IUserService userService;

        public AssignRoleToUserCommandHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<AssignRoleToUserCommandResponse> Handle(AssignRoleToUserCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
