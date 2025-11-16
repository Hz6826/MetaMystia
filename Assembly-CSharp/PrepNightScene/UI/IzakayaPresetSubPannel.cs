using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace PrepNightScene.UI
{
	// Token: 0x02000041 RID: 65
	public class IzakayaPresetSubPannel : UIPanelParamOpen<bool>
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x000B5B7C File Offset: 0x000B3D7C
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaPresetSubPannel()
		{
			Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrepNightScene.UI", "IzakayaPresetSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr);
			IzakayaPresetSubPannel.NativeFieldInfoPtr_UsePresetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, "UsePresetBtn");
			IzakayaPresetSubPannel.NativeFieldInfoPtr_DeletePresetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, "DeletePresetBtn");
			IzakayaPresetSubPannel.NativeFieldInfoPtr_SetFirstBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, "SetFirstBtn");
			IzakayaPresetSubPannel.NativeFieldInfoPtr_BackBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, "BackBtn");
			IzakayaPresetSubPannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, "SubPannel");
			IzakayaPresetSubPannel.NativeFieldInfoPtr__CloseContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, "<CloseContext>k__BackingField");
			IzakayaPresetSubPannel.NativeMethodInfoPtr_get_CloseContext_Public_get_PannelCloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664484);
			IzakayaPresetSubPannel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_PannelCloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664485);
			IzakayaPresetSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664486);
			IzakayaPresetSubPannel.NativeMethodInfoPtr_UsePresetBtnPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664487);
			IzakayaPresetSubPannel.NativeMethodInfoPtr_DeletePresetBtnPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664488);
			IzakayaPresetSubPannel.NativeMethodInfoPtr_SetFirstBtnPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664489);
			IzakayaPresetSubPannel.NativeMethodInfoPtr_ConfirmChoice_Private_Void_Boolean_PannelCloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664490);
			IzakayaPresetSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664491);
			IzakayaPresetSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664492);
			IzakayaPresetSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, 100664493);
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000B5CEC File Offset: 0x000B3EEC
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x000B5D28 File Offset: 0x000B3F28
		public unsafe IzakayaPresetSubPannel.PannelCloseContext CloseContext
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30554, RefRangeEnd = 30555, XrefRangeStart = 30554, XrefRangeEnd = 30554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubPannel.NativeMethodInfoPtr_get_CloseContext_Public_get_PannelCloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubPannel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_PannelCloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000B5D68 File Offset: 0x000B3F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30555, XrefRangeEnd = 30586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000B5DA4 File Offset: 0x000B3FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30586, XrefRangeEnd = 30587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UsePresetBtnPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubPannel.NativeMethodInfoPtr_UsePresetBtnPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000B5DD8 File Offset: 0x000B3FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30587, XrefRangeEnd = 30588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeletePresetBtnPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubPannel.NativeMethodInfoPtr_DeletePresetBtnPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000B5E0C File Offset: 0x000B400C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30588, XrefRangeEnd = 30591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFirstBtnPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubPannel.NativeMethodInfoPtr_SetFirstBtnPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000B5E40 File Offset: 0x000B4040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30611, RefRangeEnd = 30613, XrefRangeStart = 30591, XrefRangeEnd = 30611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoice(bool startWithFalse, IzakayaPresetSubPannel.PannelCloseContext pannelCloseContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startWithFalse;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pannelCloseContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubPannel.NativeMethodInfoPtr_ConfirmChoice_Private_Void_Boolean_PannelCloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000B5E8C File Offset: 0x000B408C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30613, XrefRangeEnd = 30615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(bool canUseSticky)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref canUseSticky;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000B5ED8 File Offset: 0x000B40D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000B5F14 File Offset: 0x000B4114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30615, XrefRangeEnd = 30618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaPresetSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00006719 File Offset: 0x00004919
		public IzakayaPresetSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x000B5F50 File Offset: 0x000B4150
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00006722 File Offset: 0x00004922
		public unsafe UIButtonSimple UsePresetBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_UsePresetBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_UsePresetBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000B5F80 File Offset: 0x000B4180
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00006741 File Offset: 0x00004941
		public unsafe UIButtonSimple DeletePresetBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_DeletePresetBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_DeletePresetBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x000B5FB0 File Offset: 0x000B41B0
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00006760 File Offset: 0x00004960
		public unsafe UIButtonSimple SetFirstBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_SetFirstBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_SetFirstBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x000B5FE0 File Offset: 0x000B41E0
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0000677F File Offset: 0x0000497F
		public unsafe UIButtonSimple BackBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_BackBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_BackBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x000B6010 File Offset: 0x000B4210
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x0000679E File Offset: 0x0000499E
		public unsafe IzakayaPresetSubSubPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaPresetSubSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x000B6040 File Offset: 0x000B4240
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x000067BD File Offset: 0x000049BD
		public unsafe IzakayaPresetSubPannel.PannelCloseContext _CloseContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr__CloseContext_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.NativeFieldInfoPtr__CloseContext_k__BackingField)) = value;
			}
		}

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_UsePresetBtn;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_DeletePresetBtn;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_SetFirstBtn;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_BackBtn;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr__CloseContext_k__BackingField;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseContext_Public_get_PannelCloseContext_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseContext_Private_set_Void_PannelCloseContext_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_UsePresetBtnPressed_Private_Void_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_DeletePresetBtnPressed_Private_Void_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_SetFirstBtnPressed_Private_Void_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoice_Private_Void_Boolean_PannelCloseContext_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004F3 RID: 1267
		public enum PannelCloseContext
		{
			// Token: 0x0400559A RID: 21914
			UsePreset,
			// Token: 0x0400559B RID: 21915
			DeletePreset,
			// Token: 0x0400559C RID: 21916
			SetFirstPreset,
			// Token: 0x0400559D RID: 21917
			None
		}

		// Token: 0x020004F4 RID: 1268
		[ObfuscatedName("PrepNightScene.UI.IzakayaPresetSubPannel+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x060082B7 RID: 33463 RVA: 0x0024CF3C File Offset: 0x0024B13C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<IzakayaPresetSubPannel.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaPresetSubPannel>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaPresetSubPannel.__c__DisplayClass14_0>.NativeClassPtr);
				IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubPannel.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeFieldInfoPtr_pannelCloseContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubPannel.__c__DisplayClass14_0>.NativeClassPtr, "pannelCloseContext");
				IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel.__c__DisplayClass14_0>.NativeClassPtr, 100664494);
				IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ConfirmChoice_b__0_Internal_Void_IzakayaPresetSubSubPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubPannel.__c__DisplayClass14_0>.NativeClassPtr, 100664495);
			}

			// Token: 0x060082B8 RID: 33464 RVA: 0x0024CFB8 File Offset: 0x0024B1B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaPresetSubPannel.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082B9 RID: 33465 RVA: 0x0024CFF4 File Offset: 0x0024B1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30551, XrefRangeEnd = 30554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ConfirmChoice_b__0(IzakayaPresetSubSubPannel pannel)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ConfirmChoice_b__0_Internal_Void_IzakayaPresetSubSubPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060082BA RID: 33466 RVA: 0x00046909 File Offset: 0x00044B09
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BFD RID: 11261
			// (get) Token: 0x060082BB RID: 33467 RVA: 0x0024D038 File Offset: 0x0024B238
			// (set) Token: 0x060082BC RID: 33468 RVA: 0x00046912 File Offset: 0x00044B12
			public unsafe IzakayaPresetSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaPresetSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BFE RID: 11262
			// (get) Token: 0x060082BD RID: 33469 RVA: 0x0024D068 File Offset: 0x0024B268
			// (set) Token: 0x060082BE RID: 33470 RVA: 0x00046931 File Offset: 0x00044B31
			public unsafe IzakayaPresetSubPannel.PannelCloseContext pannelCloseContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeFieldInfoPtr_pannelCloseContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubPannel.__c__DisplayClass14_0.NativeFieldInfoPtr_pannelCloseContext)) = value;
				}
			}

			// Token: 0x0400559E RID: 21918
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400559F RID: 21919
			private static readonly IntPtr NativeFieldInfoPtr_pannelCloseContext;

			// Token: 0x040055A0 RID: 21920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040055A1 RID: 21921
			private static readonly IntPtr NativeMethodInfoPtr__ConfirmChoice_b__0_Internal_Void_IzakayaPresetSubSubPannel_0;
		}
	}
}
