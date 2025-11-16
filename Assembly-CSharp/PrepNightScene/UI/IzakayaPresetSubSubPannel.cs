using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace PrepNightScene.UI
{
	// Token: 0x02000042 RID: 66
	public class IzakayaPresetSubSubPannel : UIPanel
	{
		// Token: 0x06000790 RID: 1936 RVA: 0x000B6068 File Offset: 0x000B4268
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaPresetSubSubPannel()
		{
			Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrepNightScene.UI", "IzakayaPresetSubSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr);
			IzakayaPresetSubSubPannel.NativeFieldInfoPtr_YesBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, "YesBtn");
			IzakayaPresetSubSubPannel.NativeFieldInfoPtr_NoBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, "NoBtn");
			IzakayaPresetSubSubPannel.NativeFieldInfoPtr__CloseContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, "<CloseContext>k__BackingField");
			IzakayaPresetSubSubPannel.NativeFieldInfoPtr__ShouldSelectNoByDefault_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, "<ShouldSelectNoByDefault>k__BackingField");
			IzakayaPresetSubSubPannel.NativeMethodInfoPtr_get_CloseContext_Public_get_PannelCloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, 100664496);
			IzakayaPresetSubSubPannel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_PannelCloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, 100664497);
			IzakayaPresetSubSubPannel.NativeMethodInfoPtr_get_ShouldSelectNoByDefault_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, 100664498);
			IzakayaPresetSubSubPannel.NativeMethodInfoPtr_set_ShouldSelectNoByDefault_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, 100664499);
			IzakayaPresetSubSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, 100664500);
			IzakayaPresetSubSubPannel.NativeMethodInfoPtr_OnYes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, 100664501);
			IzakayaPresetSubSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, 100664502);
			IzakayaPresetSubSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, 100664503);
			IzakayaPresetSubSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr, 100664504);
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x000B619C File Offset: 0x000B439C
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x000B61D8 File Offset: 0x000B43D8
		public unsafe IzakayaPresetSubSubPannel.PannelCloseContext CloseContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubSubPannel.NativeMethodInfoPtr_get_CloseContext_Public_get_PannelCloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubSubPannel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_PannelCloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000B6218 File Offset: 0x000B4418
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x000B6254 File Offset: 0x000B4454
		public unsafe bool ShouldSelectNoByDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubSubPannel.NativeMethodInfoPtr_get_ShouldSelectNoByDefault_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubSubPannel.NativeMethodInfoPtr_set_ShouldSelectNoByDefault_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000B6294 File Offset: 0x000B4494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30618, XrefRangeEnd = 30634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetSubSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000B62D0 File Offset: 0x000B44D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30634, XrefRangeEnd = 30635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnYes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubSubPannel.NativeMethodInfoPtr_OnYes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000B6304 File Offset: 0x000B4504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30635, XrefRangeEnd = 30637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetSubSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000B6340 File Offset: 0x000B4540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaPresetSubSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000B637C File Offset: 0x000B457C
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaPresetSubSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaPresetSubSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaPresetSubSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000067D8 File Offset: 0x000049D8
		public IzakayaPresetSubSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x000B63B8 File Offset: 0x000B45B8
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x000067E1 File Offset: 0x000049E1
		public unsafe UIButtonSimple YesBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubSubPannel.NativeFieldInfoPtr_YesBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubSubPannel.NativeFieldInfoPtr_YesBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x000B63E8 File Offset: 0x000B45E8
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00006800 File Offset: 0x00004A00
		public unsafe UIButtonSimple NoBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubSubPannel.NativeFieldInfoPtr_NoBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubSubPannel.NativeFieldInfoPtr_NoBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x000B6418 File Offset: 0x000B4618
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x0000681F File Offset: 0x00004A1F
		public unsafe IzakayaPresetSubSubPannel.PannelCloseContext _CloseContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubSubPannel.NativeFieldInfoPtr__CloseContext_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubSubPannel.NativeFieldInfoPtr__CloseContext_k__BackingField)) = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x000B6440 File Offset: 0x000B4640
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x0000683A File Offset: 0x00004A3A
		public unsafe bool _ShouldSelectNoByDefault_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubSubPannel.NativeFieldInfoPtr__ShouldSelectNoByDefault_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaPresetSubSubPannel.NativeFieldInfoPtr__ShouldSelectNoByDefault_k__BackingField)) = value;
			}
		}

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_YesBtn;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_NoBtn;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr__CloseContext_k__BackingField;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr__ShouldSelectNoByDefault_k__BackingField;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseContext_Public_get_PannelCloseContext_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseContext_Private_set_Void_PannelCloseContext_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSelectNoByDefault_Private_get_Boolean_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldSelectNoByDefault_Public_set_Void_Boolean_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_OnYes_Private_Void_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004F5 RID: 1269
		public enum PannelCloseContext
		{
			// Token: 0x040055A3 RID: 21923
			Yes,
			// Token: 0x040055A4 RID: 21924
			No
		}
	}
}
