import http from '@/utils/request'
import defaultSettings from '@/settings'

/**
   * 系统分页查询
   * @param {查询条件} data
   */
export function getLogListWithPager(data) {
  return http.request({
    url: 'Log/FindWithPagerAsync',
    method: 'get',
    params: data,
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}
/**
   * 获取系统详情
   * @param {Id} 系统Id
   */
export function getLogDetail(id) {
  return http({
    url: 'Log/GetById?id=' + id,
    method: 'get',
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}
/**
   * 批量删除
   * @param {id集合} ids
   */
export function deleteLog(data) {
  return http({
    url: 'Log/DeleteBatchAsync',
    method: 'delete',
    params: data,
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}
