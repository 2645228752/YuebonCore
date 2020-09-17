import http from '@/utils/request'
import defaultSettings from '@/settings'

/**
   * 分页查询
   * @param {查询条件} data
   */
export function getSequenceListWithPager(data) {
  return http.request({
    url: 'Sequence/FindWithPagerAsync',
    method: 'get',
    params: data,
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}/**
   * 获取所有可用的
   */
export function getAllSequenceList() {
  return http.request({
    url: 'Sequence/GetAllEnable',
    method: 'get',
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}
/**
   * 新增或修改保存
   * @param data
   */
export function saveSequence(data) {
  return http.request({
    url: 'Sequence/InsertOrUpdateAsync',
    method: 'post',
    data: data,
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}
/**
   * 获取详情
   * @param {Id} Id
   */
export function getSequenceDetail(id) {
  return http({
    url: 'Sequence/GetById?id=' + id,
    method: 'get',
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}
/**
   * 批量设置启用状态
   * @param {id集合} ids
   */
export function setSequenceEnable(data) {
  return http({
    url: 'Sequence/SetEnabledMarktBatchAsync',
    method: 'post',
    params: data,
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}
/**
   * 批量软删除
   * @param {id集合} ids
   */
export function deleteSoftSequence(data) {
  return http({
    url: 'Sequence/DeleteSoftBatchAsync',
    method: 'post',
    params: data,
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}

/**
   * 批量删除
   * @param {id集合} ids
   */
export function deleteSequence(data) {
  return http({
    url: 'Sequence/DeleteBatchAsync',
    method: 'delete',
    params: data,
    baseURL: defaultSettings.apiWSecurityUrl // 直接通过覆盖的方式
  })
}
