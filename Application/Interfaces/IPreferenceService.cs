﻿using Application.Models;

namespace Application.Interfaces
{
    public interface IPreferenceService
    {
        Task<PreferenceResponse> Insert(PreferenceReq request);
        Task<IEnumerable<PreferenceResponse>> GetAll();
        Task<IEnumerable<PreferenceResponse>> GetAllByUserId(int UserId);
        Task<IEnumerable<PreferenceResponseFull>> GetAllByUserIdFull(int UserId);
        Task<PreferenceResponse> GetByid(int UserId, int InterestId);
        Task<PreferenceResponse> Update(PreferenceReq request);
        Task<PreferenceResponse> Delete(PreferenceReqId request);
    }
}
