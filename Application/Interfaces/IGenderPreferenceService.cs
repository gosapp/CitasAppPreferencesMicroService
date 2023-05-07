﻿using Application.Models;

namespace Application.Interfaces
{
    public interface IGenderPreferenceService
    {
        Task<GenderPreferenceResponse> Insert(string userurl, GenderPreferenceReq request);
        Task<IEnumerable<GenderPreferenceResponse>> GetAllByUserId(string userurl, int userId);
        Task<GenderPreferenceResponse> Delete(string userurl, GenderPreferenceReq request);
    }
}
