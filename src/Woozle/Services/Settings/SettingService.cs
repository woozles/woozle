﻿using AutoMapper;
using ServiceStack.ServiceInterface;
using Woozle.Domain.Settings;
using Woozle.Model;
using Woozle.Model.Validation.Creation;
using Woozle.Services.Authority;

namespace Woozle.Services.Settings
{
    [Authenticate]
    public class SettingService : AbstractService
    {
        private readonly ISettingsLogic settingsLogic;

        public SettingService(ISettingsLogic settingsLogic)
        {
            this.settingsLogic = settingsLogic;
        }

        /// <summary>
        /// Gets one specific Settings
        /// </summary>
        /// <returns></returns>
        [ExceptionCatcher]
        public Setting Get(Setting requestDto)
        {
            var result = settingsLogic.Load(Session.SessionData);
            var response = Mapper.Map<Woozle.Model.Setting, Setting>(result);
            return response;
        }

        /// <summary>
        /// Inserts a given object
        /// </summary>
        /// <param name="requestDto"></param>
        /// <returns></returns>
        [ExceptionCatcher]
        [RequiredRole(Roles.Administrator)]
        public SaveResultDto<Setting> Post(Setting requestDto)
        {
            return Save(requestDto);
        }

        /// <summary>
        /// Updates a given object
        /// </summary>
        /// <param name="requestDto"></param>
        /// <returns></returns>
        [ExceptionCatcher]
        [RequiredRole(Roles.Administrator)]
        public SaveResultDto<Setting> Put(Setting requestDto)
        {
            return Save(requestDto);
        }

        private SaveResultDto<Setting> Save(Setting requestDto)
        {
            var saveResult = this.settingsLogic.Save(Mapper.Map<Setting, Woozle.Model.Setting>(requestDto), Session.SessionData);
            var result =
                Mapper.Map<ISaveResult<Setting>, SaveResultDto<Setting>>(saveResult);
            return result;
        }
    }
}
