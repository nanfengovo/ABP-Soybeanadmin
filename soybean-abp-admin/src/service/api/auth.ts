import { request } from '../request';
import qs from 'qs';


/**
 * Login
 *
 * @param userName User name
 * @param password Password
 */
export function fetchLogin(userName: string, password: string) {
  return request<Api.Auth.LoginToken>({
    url: '/connect/token',
    method: 'post',
    data: qs.stringify({
      grant_type: 'password',
      client_id: 'ABP_Admin_Password',
      scope: 'ABP_Admin offline_access',
      username: userName,
      password: password
    }),headers:{
      'Content-Type': 'application/x-www-form-urlencoded'
    }
  });
}

/** Get user info */
export function fetchGetUserInfo(userName: string) {
  return request<Api.Auth.AbpUserInfo>({ url: `/api/identity/users/by-username/${userName}` });
}

export function fetchGetRoleByUserId(userId: string) {
  return request<Api.Auth.AbpListResult<Api.Auth.Role>>({ url: `/api/identity/users/${userId}/roles` });
}

export function fetchGetPermissionsByRole(roleName: string) {
  return request<Api.Auth.AbpPermissionResult>({ url: `/api/permission-management/permissions`,params: { providerName: 'R', providerKey: roleName } });
}

/**
 * Refresh token
 *
 * @param refreshToken Refresh token
 */
export function fetchRefreshToken(refreshToken: string) {
  return request<Api.Auth.LoginToken>({
    url: '/auth/refreshToken',
    method: 'post',
    data: {
      refreshToken
    }
  });
}

/**
 * return custom backend error
 *
 * @param code error code
 * @param msg error message
 */
export function fetchCustomBackendError(code: string, msg: string) {
  return request({ url: '/auth/error', params: { code, msg } });
}
