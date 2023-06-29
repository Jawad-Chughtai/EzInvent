import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'EzInvent',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44388/',
    redirectUri: baseUrl,
    clientId: 'EzInvent_App',
    responseType: 'code',
    scope: 'offline_access EzInvent',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44388',
      rootNamespace: 'EzInvent',
    },
  },
} as Environment;
