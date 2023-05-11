using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackernewsUI.Domain.Dto;
using System.Collections.Generic;

namespace HackernewsUI.Domain.Interfaces
{
    public interface IHackersnewsHandlers
    {
        Task <NewsfeedResponseDto> Pullnewsfeed()
    }
}
