<template>
  <div class="app-container">
    <el-card>
      <el-row :gutter="24">
        <el-col :span="10">
          <div class="grid-content bg-purple">
            <div class="grid-content bg-purple">
              <div class="list-btn-container">
                <el-form ref="searchmenuform" :inline="true" :model="searchform" class="demo-form-inline" size="small">
                  <el-form-item>
                    <el-button-group>
                      <el-button type="default" icon="el-icon-refresh" size="small" @click="loadTableData()">刷新</el-button>
                      <el-button
                        v-hasPermi="['Items/Add']"
                        type="primary"
                        icon="el-icon-plus"
                        size="small"
                        @click="ShowItemsEditOrViewDialog()"
                      >新增</el-button>
                      <el-button
                        v-hasPermi="['Items/Edit']"
                        type="primary"
                        icon="el-icon-edit"
                        class="el-button-modify"
                        size="small"
                        @click="ShowItemsEditOrViewDialog('edit')"
                      >修改</el-button>
                      <el-button
                        v-hasPermi="['Items/Enable']"
                        type="info"
                        icon="el-icon-video-pause"
                        size="small"
                        @click="setItemsEnable('0')"
                      >禁用</el-button>
                      <el-button
                        v-hasPermi="['Items/Enable']"
                        type="success"
                        icon="el-icon-video-play"
                        size="small"
                        @click="setItemsEnable('1')"
                      >启用</el-button>
                      <el-button
                        v-hasPermi="['Items/Delete']"
                        type="danger"
                        icon="el-icon-delete"
                        size="small"
                        @click="deleteItemsPhysics()"
                      >删除</el-button>
                    </el-button-group>
                  </el-form-item>
                </el-form>
              </div>
              <el-table
                :data="tableDataItemss"
                style="width: 100%;margin-bottom: 20px;"
                row-key="Id"
                border
                size="mini"
                max-height="850"
                default-expand-all
                highlight-current-row
                :tree-props="{children: 'Children'}"
                @row-click="handleClickItemsChange"
              >
                <el-table-column
                  prop="FullName"
                  label="名称"
                />
                <el-table-column
                  label="状态"
                  width="80"
                  prop="EnabledMark"
                  align="center"
                >
                  <template slot-scope="scope">
                    <el-tag
                      :type="scope.row.EnabledMark === true ? 'success' : 'info'"
                      disable-transitions
                    >{{ scope.row.EnabledMark===true?'启用':'禁用' }}</el-tag>
                  </template>
                </el-table-column>
              </el-table>
            </div>
          </div>
        </el-col>
        <el-col :span="14">
          <div class="grid-content bg-purple">
            <div class="list-btn-container">
              <el-form ref="searchform" :inline="true" :model="searchform" class="demo-form-inline" size="small">
                <el-form-item>
                  <el-button-group>
                    <el-button type="default" icon="el-icon-refresh" size="small" @click="loadItemsDetailTableData()">刷新</el-button>
                    <el-button
                      v-hasPermi="['ItemsDetail/Add']"
                      type="primary"
                      icon="el-icon-plus"
                      size="small"
                      @click="ShowItemsDetailEditOrViewDialog()"
                    >新增</el-button>
                    <el-button
                      v-hasPermi="['ItemsDetail/Edit']"
                      type="primary"
                      icon="el-icon-edit"
                      class="el-button-modify"
                      size="small"
                      @click="ShowItemsDetailEditOrViewDialog('edit')"
                    >修改</el-button>
                    <el-button
                      v-hasPermi="['ItemsDetail/Enable']"
                      type="info"
                      icon="el-icon-video-pause"
                      size="small"
                      @click="setItemsDetailEnable('0')"
                    >禁用</el-button>
                    <el-button
                      v-hasPermi="['ItemsDetail/Enable']"
                      type="success"
                      icon="el-icon-video-play"
                      size="small"
                      @click="setItemsDetailEnable('1')"
                    >启用</el-button>
                    <el-button v-hasPermi="['ItemsDetail/Delete']" type="danger" icon="el-icon-delete" size="small" @click="deleteItemsDetailPhysics()">删除</el-button>
                  </el-button-group>
                </el-form-item>
              </el-form>
            </div>
          </div>

          <el-table
            ref="gridtable"
            :data="tableData"
            style="width: 100%;margin-bottom: 20px;"
            row-key="Id"
            border
            size="mini"
            max-height="850"
            default-expand-all
            highlight-current-row
            :tree-props="{children: 'Children'}"
            @select="handleSelectChange"
            @select-all="handleSelectAllChange"
          >
            <el-table-column
              type="selection"
              width="30"
            />
            <el-table-column
              prop="ItemName"
              label="名称"
              sortable="custom"
            />
            <el-table-column
              prop="ItemCode"
              label="值"
              sortable="custom"
            />
            <el-table-column
              prop="SortCode"
              label="排序"
              sortable="custom"
              width="80"
              align="center"
            />
            <el-table-column
              label="状态"
              sortable="custom"
              width="80"
              prop="EnabledMark"
              align="center"
            >
              <template slot-scope="scope">
                <el-tag
                  :type="scope.row.EnabledMark === true ? 'success' : 'info'"
                  disable-transitions
                >{{ scope.row.EnabledMark===true?'启用':'禁用' }}</el-tag>
              </template>
            </el-table-column>
          </el-table>
        </el-col>
      </el-row>
    </el-card>
    <el-dialog ref="dialogEditItemsForm" :title="editItemsFormTitle+'字典'" :visible.sync="dialogItemsEditFormVisible" width="30%">
      <el-form ref="editItemsFrom" :model="editItemsFrom" :rules="rules">
        <el-form-item label="字典名称" :label-width="formLabelWidth" prop="FullName">
          <el-input v-model="editItemsFrom.FullName" placeholder="请输入字典名称" autocomplete="off" clearable />
        </el-form-item>
        <el-form-item label="字典编码" :label-width="formLabelWidth" prop="EnCode">
          <el-input v-model="editItemsFrom.EnCode" placeholder="请输入字典编码" autocomplete="off" clearable />
        </el-form-item>
        <el-form-item label="父级" :label-width="formLabelWidth" prop="ParentId">
          <el-cascader
            v-model="selectedItemsOptions"
            :options="selectItemss"
            filterable
            :props="{label:'FullName',value:'Id',children:'Children',emitPath:false, checkStrictly: true,expandTrigger: 'hover' }"
            clearable
            @change="handleItemsChange"
          />
        </el-form-item>
        <el-form-item label="排序" :label-width="formLabelWidth" prop="SortCode">
          <el-input v-model.number="editItemsFrom.SortCode" placeholder="请输入排序,默认为99" autocomplete="off" clearable />
        </el-form-item>
        <el-form-item label="属性" :label-width="formLabelWidth" prop="">
          <el-checkbox v-model="editItemsFrom.EnabledMark">启用</el-checkbox>
          <el-checkbox v-model="editItemsFrom.IsTree">是否是树</el-checkbox>
        </el-form-item>
      </el-form>
      <div slot="footer" class="dialog-footer">
        <el-button @click="dialogItemsEditFormVisible = false">取 消</el-button>
        <el-button type="primary" @click="saveEditItemsForm()">确 定</el-button>
      </div>
    </el-dialog>

    <el-dialog ref="dialogEditItemsDetailForm" :title="editItemsDetailFormTitle+'功能'" :visible.sync="dialogItemsDetailEditFormVisible" width="30%">
      <el-form ref="editItemsDetailFrom" :model="editItemsDetailFrom" :rules="rulesfun">
        <el-form-item label="名称" :label-width="formLabelWidth" prop="ItemName">
          <el-input v-model="editItemsDetailFrom.ItemName" placeholder="请输入名称" autocomplete="off" clearable />
        </el-form-item>
        <el-form-item label="值" :label-width="formLabelWidth" prop="ItemCode">
          <el-input v-model="editItemsDetailFrom.ItemCode" placeholder="请输入值" autocomplete="off" clearable />
        </el-form-item>
        <el-form-item label="分类" :label-width="formLabelWidth" prop="ItemId">
          <el-cascader
            v-model="selectedItemsOptions"
            :options="selectItemss"
            filterable
            :props="{label:'FullName',value:'Id',children:'Children',emitPath:false, checkStrictly: true,expandTrigger: 'hover' }"
            clearable
            @change="handleAddItemsDetailChange"
          />
        </el-form-item>
        <el-form-item label="上级功能" :label-width="formLabelWidth" prop="ParentId">
          <el-cascader
            v-model="selectedItemsDetailOptions"
            :options="selectItemsDetails"
            filterable
            :props="{label:'ItemName',value:'Id',children:'Children',emitPath:false, checkStrictly: true,expandTrigger: 'hover' }"
            clearable
            @change="handleAddItemsDetailItemsChange"
          />
        </el-form-item>
        <el-form-item label="排序" :label-width="formLabelWidth" prop="SortCode">
          <el-input v-model.number="editItemsDetailFrom.SortCode" placeholder="请输入排序,默认为99" autocomplete="off" clearable />
        </el-form-item>
        <el-form-item label="属性" :label-width="formLabelWidth" prop="">
          <el-checkbox v-model="editItemsDetailFrom.EnabledMark">启用</el-checkbox>
          <el-checkbox v-model="editItemsDetailFrom.IsDefault">默认值</el-checkbox>
        </el-form-item>
      </el-form>
      <div slot="footer" class="dialog-footer">
        <el-button @click="dialogItemsDetailEditFormVisible = false">取 消</el-button>
        <el-button type="primary" @click="saveEditItemsDetailForm()">确 定</el-button>
      </div>
    </el-dialog>
  </div>
</template>

<script>
import { getAllItemsTreeTable, getItemsDetail, saveItems, setItemsEnable, deleteSoftItems, deleteItems,
  getItemsDetailListWithPager,
  getItemsDetailDetail, saveItemsDetail, setItemsDetailEnable, deleteSoftItemsDetail,
  deleteItemsDetail,
  getAllItemsDetailTreeTable
} from '@/api/security/itemsservice'

import { getListMeunFuntionBymeunCode } from '@/api/basebasic'
export default {
  name: 'Items',
  data() {
    return {
      searchform: {
        keywords: '',
        code: ''
      },
      searchmenuform: {
        systemTypeId: ''
      },
      selectSystemType: [],
      loadItemsBtnFunc: [],
      loadItemsDetailBtnFunc: [],
      tableData: [],
      tableloading: true,
      pagination: {
        currentPage: 1,
        pagesize: 20,
        pageTotal: 0
      },
      sortableData: {
        order: '',
        sort: ''
      },
      selectItemsId: '',
      dialogItemsEditFormVisible: false,
      editItemsFormTitle: '',
      selectedItemsOptions: [],
      selectItemss: [],
      editItemsFrom: {
      },
      rules: {
        FullName: [
          { required: true, message: '请输入名称', trigger: 'blur' },
          { min: 2, max: 50, message: '长度在 2 到 50 个字符', trigger: 'blur' }
        ],
        EnCode: [
          { required: true, message: '请输入编码', trigger: 'blur' },
          { min: 2, max: 50, message: '长度在 2 到 50 个字符', trigger: 'blur' }
        ]
      },
      formLabelWidth: '80px',
      currentItemsId: '',

      dialogItemsDetailEditFormVisible: false,
      editItemsDetailFormTitle: '',
      selectedItemsDetailOptions: [],
      selectItemsDetails: [],
      editItemsDetailFrom: {},
      rulesfun: {
        ItemName: [
          { required: true, message: '请输入名称', trigger: 'blur' },
          { min: 2, max: 50, message: '长度在 2 到 50 个字符', trigger: 'blur' }
        ],
        ItemCode: [
          { required: true, message: '请输入值', trigger: 'blur' },
          { min: 1, max: 50, message: '长度在 1 到 50 个字符', trigger: 'blur' }
        ],
        ItemId: [
          { required: true, message: '请选择所属分类', trigger: 'blur' }
        ]
      },
      currentId: '', // 当前操作对象的ID值，主要用于修改
      currentSelected: [],
      tableDataItemss: []
    }
  },
  created() {
    this.pagination.currentPage = 1
    this.InitDictItem()
    this.loadTableData()
  },
  methods: {
    /**
     * 初始化数据
     */
    InitDictItem() {
      getListMeunFuntionBymeunCode('ItemsDetail').then(res => {
        this.loadItemsDetailBtnFunc = res.ResData
      })
    },
    /**
     * 加载页面左侧菜单table数据
     */
    loadTableData: function() {
      getAllItemsTreeTable().then(res => {
        this.selectItemss = this.tableDataItemss = res.ResData
      })
    },
    /**
     * 点击查询菜单
     */
    handleSearch: function() {
      this.loadTableData()
    },
    /**
     * 点击查询
     */
    handleSearchItemsDetail: function() {
      this.pagination.currentPage = 1
      this.loadItemsDetailTableData()
    },

    loadItemsDetailTree() {
      var data = {
        itemId: this.selectItemsId
      }
      getAllItemsDetailTreeTable(data).then(res => {
        this.selectItemsDetails = res.ResData
      })
    },
    /**
     * 添加添加分类是选择父级分类
     */
    handleItemsChange: function() {
      if (this.currentItemsId === this.selectedItemsOptions) {
        this.$alert('不能选择自己作为父级', '提示')
        this.selectedItemsOptions = ''
        return
      }
      this.editItemsFrom.ParentId = this.selectedItemsOptions
    },
    /**
     * 添加分类值是选择分类
     */
    handleAddItemsDetailChange: function() {
      this.selectItemsId = this.selectedItemsOptions
      this.loadItemsDetailTree()
      this.editItemsDetailFrom.ItemId = this.selectedItemsOptions
    },
    /**
     * 添加分类值时选择父级
     */
    handleAddItemsDetailItemsChange: function() {
      if (this.currentId === this.selectedItemsDetailOptions) {
        this.$alert('不能选择自己作为父级', '提示')
        this.selectedItemsDetailOptions = ''
        return
      }
      this.editItemsDetailFrom.ParentId = this.selectedItemsDetailOptions
    },

    // 表单重置
    reset() {
      this.editItemsFrom = {
        FullName: '',
        EnCode: '',
        ParentId: '',
        IsTree: false,
        EnabledMark: true,
        SortCode: 99
      }
      this.selectedItemsOptions = ''
      this.resetForm('editItemsFrom')
    },
    /**
     * 新增、修改或查看明细信息（绑定显示数据）*
     */
    ShowItemsEditOrViewDialog: function(view) {
      this.reset()
      if (view !== undefined) {
        if (this.currentItemsId === '') {
          this.$alert('请选择一条数据进行编辑/修改', '提示')
        } else {
          this.editItemsFormTitle = '编辑'
          this.dialogItemsEditFormVisible = true
          this.bindItemsEditInfo()
        }
      } else {
        this.editItemsFormTitle = '新增'
        this.currentItemsId = ''
        this.dialogItemsEditFormVisible = true
      }
    },
    bindItemsEditInfo: function() {
      getItemsDetail(this.currentItemsId).then(res => {
        this.editItemsFrom = res.ResData
        this.selectedItemsOptions = res.ResData.ParentId
      })
    },
    /**
     * 新增/修改保存
     */
    saveEditItemsForm() {
      this.$refs['editItemsFrom'].validate((valid) => {
        if (valid) {
          const data = {
            'FullName': this.editItemsFrom.FullName,
            'EnCode': this.editItemsFrom.EnCode,
            'ParentId': this.editItemsFrom.ParentId,
            'IsTree': this.editItemsFrom.IsTree,
            'EnabledMark': this.editItemsFrom.EnabledMark,
            'SortCode': this.editItemsFrom.SortCode,
            'Id': this.currentItemsId
          }
          var url = 'Items/Insert'
          if (this.currentItemsId !== '') {
            url = 'Items/Update'
          }
          saveItems(data, url).then(res => {
            if (res.Success) {
              this.$message({
                message: '恭喜你，操作成功',
                type: 'success'
              })
              this.dialogItemsEditFormVisible = false
              this.currentItemsId = ''
              this.selectedItemsOptions = ''
              this.$refs['editItemsFrom'].resetFields()
              this.loadTableData()
              this.InitDictItem()
            } else {
              this.$message({
                message: res.ErrMsg,
                type: 'error'
              })
            }
          })
        } else {
          return false
        }
      })
    },
    setItemsEnable: function(val) {
      if (this.currentItemsId === '') {
        this.$alert('请先选择要操作的数据', '提示')
        return false
      } else {
        var currentIds = [this.currentItemsId]
        const data = {
          Ids: currentIds,
          Flag: val
        }
        setItemsEnable(data).then(res => {
          if (res.Success) {
            this.$message({
              message: '恭喜你，操作成功',
              type: 'success'
            })
            this.currentItemsId = ''
            this.loadTableData()
          } else {
            this.$message({
              message: res.ErrMsg,
              type: 'error'
            })
          }
        })
      }
    },
    deleteItemsSoft: function(val) {
      if (this.currentItemsId === '') {
        this.$alert('请先选择要操作的数据', '提示')
        return false
      } else {
        var currentIds = [this.currentItemsId]
        const data = {
          Ids: currentIds,
          Flag: val
        }
        deleteSoftItems(data).then(res => {
          if (res.Success) {
            this.$message({
              message: '恭喜你，操作成功',
              type: 'success'
            })
            this.currentItemsId = ''
            this.loadTableData()
          } else {
            this.$message({
              message: res.ErrMsg,
              type: 'error'
            })
          }
        })
      }
    },
    deleteItemsPhysics: function() {
      if (this.currentItemsId === '') {
        this.$alert('请先选择要操作的数据', '提示')
        return false
      } else {
        var currentIds = [this.currentItemsId]
        this.$confirm('是否确认删除所选的数据项?', '警告', {
          confirmButtonText: '确定',
          cancelButtonText: '取消',
          type: 'warning'
        }).then(function() {
          const data = {
            Ids: currentIds
          }
          return deleteItems(data)
        }).then(res => {
          if (res.Success) {
            this.$message({
              message: '恭喜你，删除成功',
              type: 'success'
            })
            this.currentSelected = ''
            this.loadTableData()
          } else {
            this.$message({
              message: res.ErrMsg,
              type: 'error'
            })
          }
        })
      }
    },

    // 表单重置
    resetDetails() {
      this.editItemsDetailFrom = {
        ItemName: '',
        ItemCode: '',
        ParentId: '',
        ItemId: '',
        IsDefault: false,
        EnabledMark: true,
        SortCode: 99
      }
      this.selectedItemsOptions = ''
      this.resetForm('editItemsDetailFrom')
    },
    /**
     * 新增、修改或查看明细信息（绑定显示数据）*
     */
    ShowItemsDetailEditOrViewDialog: function(view) {
      this.resetDetails()
      if (view !== undefined) {
        if (this.currentSelected.length === 0) {
          this.$alert('请选择一条数据进行编辑/修改', '提示')
        } else {
          this.editItemsDetailFormTitle = '编辑'
          this.dialogItemsDetailEditFormVisible = true
          this.currentId = this.currentSelected[0].Id
          this.bindItemsDetailEditInfo()
        }
      } else {
        this.editItemsDetailFormTitle = '新增'
        this.currentId = ''
        this.dialogItemsDetailEditFormVisible = true
      }
    },
    bindItemsDetailEditInfo: function() {
      getItemsDetailDetail(this.currentId).then(res => {
        this.editItemsDetailFrom = res.ResData
        this.editItemsDetailFrom.ItemId = res.ResData.ItemId
        this.selectedItemsOptions = res.ResData.ItemId
        this.selectItemsId = res.ResData.ItemId
        this.loadItemsDetailTree()
      })
    },
    /**
     * 新增/修改保存
     */
    saveEditItemsDetailForm() {
      this.$refs['editItemsDetailFrom'].validate((valid) => {
        if (valid) {
          const data = {
            'ItemName': this.editItemsDetailFrom.ItemName,
            'ItemCode': this.editItemsDetailFrom.ItemCode,
            'ItemId': this.editItemsDetailFrom.ItemId,
            'ParentId': this.editItemsDetailFrom.ParentId,
            'IsDefault': this.editItemsDetailFrom.IsDefault,
            'EnabledMark': this.editItemsDetailFrom.EnabledMark,
            'SortCode': this.editItemsDetailFrom.SortCode,
            'Id': this.currentId
          }

          var url = 'ItemsDetail/Insert'
          if (this.currentId !== '') {
            url = 'ItemsDetail/Update'
          }
          saveItemsDetail(data, url).then(res => {
            if (res.Success) {
              this.$message({
                message: '恭喜你，操作成功',
                type: 'success'
              })
              this.dialogItemsDetailEditFormVisible = false
              this.currentSelected = ''
              this.selectedItemsOptions = ''
              this.loadItemsDetailTableData()
              this.InitDictItem()
            } else {
              this.$message({
                message: res.ErrMsg,
                type: 'error'
              })
            }
          })
        } else {
          return false
        }
      })
    },
    setItemsDetailEnable: function(val) {
      if (this.currentSelected.length === 0) {
        this.$alert('请先选择要操作的数据', '提示')
        return false
      } else {
        var currentIds = []
        this.currentSelected.forEach(element => {
          currentIds.push(element.Id)
        })
        const data = {
          Ids: currentIds,
          Flag: val
        }
        setItemsDetailEnable(data).then(res => {
          if (res.Success) {
            this.$message({
              message: '恭喜你，操作成功',
              type: 'success'
            })
            this.currentSelected = ''
            this.loadItemsDetailTableData()
          } else {
            this.$message({
              message: res.ErrMsg,
              type: 'error'
            })
          }
        })
      }
    },
    deleteItemsDetailSoft: function(val) {
      if (this.currentSelected.length === 0) {
        this.$alert('请先选择要操作的数据', '提示')
        return false
      } else {
        var currentIds = []
        this.currentSelected.forEach(element => {
          currentIds.push(element.Id)
        })
        const data = {
          Ids: currentIds,
          Flag: val
        }
        deleteSoftItemsDetail(data).then(res => {
          if (res.Success) {
            this.$message({
              message: '恭喜你，操作成功',
              type: 'success'
            })
            this.currentSelected = ''
            this.loadItemsDetailTableData()
          } else {
            this.$message({
              message: res.ErrMsg,
              type: 'error'
            })
          }
        })
      }
    },
    deleteItemsDetailPhysics: function() {
      if (this.currentSelected.length === 0) {
        this.$alert('请先选择要操作的数据', '提示')
        return false
      } else {
        var currentIds = []
        this.currentSelected.forEach(element => {
          currentIds.push(element.Id)
        })
        this.$confirm('是否确认删除所选的数据项?', '警告', {
          confirmButtonText: '确定',
          cancelButtonText: '取消',
          type: 'warning'
        }).then(function() {
          const data = {
            Ids: currentIds
          }
          return deleteItemsDetail(data)
        }).then(res => {
          if (res.Success) {
            this.$message({
              message: '恭喜你，删除成功',
              type: 'success'
            })
            this.currentSelected = ''
            this.loadTableData()
          } else {
            this.$message({
              message: res.ErrMsg,
              type: 'error'
            })
          }
        })
      }
    },
    /**
     * 当表格的排序条件发生变化的时候会触发该事件
     */
    handleSortChange: function(column) {
      this.sortableData.sort = column.prop
      if (column.order === 'ascending') {
        this.sortableData.order = 'asc'
      } else {
        this.sortableData.order = 'desc'
      }
      this.loadItemsDetailTableData()
    },
    //
    handleClickItemsChange: function(row, column, event) {
      this.searchform.code = row.EnCode
      this.currentItemsId = row.Id
      this.loadItemsDetailTableData()
    },
    /**
     * 当用户手动勾选checkbox数据行事件
     */
    handleSelectChange: function(selection, row) {
      this.currentSelected = selection
    },
    /**
     * 当用户手动勾选全选checkbox事件
     */
    handleSelectAllChange: function(selection) {
      this.currentSelected = selection
    },

    /**
     * 加载数据字典值列表数据
     */
    loadItemsDetailTableData: function() {
      this.tableloading = true
      var seachdata = {
        itemId: this.currentItemsId
      }
      getItemsDetailListWithPager(seachdata).then(res => {
        this.tableData = res.ResData
        this.tableloading = false
      })
    }

  }
}
</script>
<style>
.el-cascader{
  width: 100%;
}
</style>
