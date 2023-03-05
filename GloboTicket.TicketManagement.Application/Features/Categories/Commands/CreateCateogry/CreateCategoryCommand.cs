using MediatR;

using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommand: IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
    }
}
