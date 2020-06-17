﻿namespace Ekin.Clarizen.Files
{
    public class getUploadUrl : Call<Result.getUploadUrl>
    {
        public getUploadUrl(CallSettings callSettings)
        {
            _callSettings = callSettings;
            _url = (callSettings.isBulk ? string.Empty : callSettings.serverLocation) + "/files/getUploadUrl";
            _method = requestMethod.Get;

            var result = Execute();
        }
    }
}