declare namespace Api {
  /**
   * namespace Auth
   *
   * backend api module: "auth"
   */
  namespace Auth {
    interface LoginToken {
      access_token: string;
      refresh_token: string;
    }

    interface UserInfo {
      userId: string;
      userName: string;
      roles: string[];
      buttons: string[];
    }

    /** ABP Identity User */
    interface AbpUserInfo {
      id: string;
      userName: string;
      email: string;
      name: string;
      surname: string;
      phoneNumber: string;
      isActive: boolean;
      lockoutEnabled: boolean;
      concurrencyStamp: string;
      extraProperties: Record<string, any>;
    }

    interface Role{
      name: string;
      isDefault: boolean;
      isStatic: boolean;
      isPublic: boolean;
      concurrencyStamp: string;
      id: string;
      extraProperties:{};
    }

    interface AbpListResult<T> {
      items: T[];
    }

    // 定义 ABP 权限接口的具体结构
    interface PermissionDto {
      name: string;
      isGranted: boolean;
      // ... 其他属性
    }

    interface PermissionGroupDto {
      displayName: string;
      permissions: PermissionDto[];
    }

    interface AbpPermissionResult {
      entityDisplayName: string;
      groups: PermissionGroupDto[];
    }
  }
}
