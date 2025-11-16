using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace PrepNightScene.UI
{
	// Token: 0x02000043 RID: 67
	public class RemindSubPanel : UIPanelParamOpen<string>
	{
		// Token: 0x060007A3 RID: 1955 RVA: 0x000B6468 File Offset: 0x000B4668
		// Note: this type is marked as 'beforefieldinit'.
		static RemindSubPanel()
		{
			Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrepNightScene.UI", "RemindSubPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr);
			RemindSubPanel.NativeFieldInfoPtr_m_RemindContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, "m_RemindContext");
			RemindSubPanel.NativeFieldInfoPtr_m_RemindConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, "m_RemindConfirmButton");
			RemindSubPanel.NativeFieldInfoPtr_m_RemindRefuseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, "m_RemindRefuseButton");
			RemindSubPanel.NativeFieldInfoPtr__CloseContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, "<CloseContext>k__BackingField");
			RemindSubPanel.NativeMethodInfoPtr_get_CloseContext_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, 100664505);
			RemindSubPanel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, 100664506);
			RemindSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, 100664507);
			RemindSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, 100664508);
			RemindSubPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, 100664509);
			RemindSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, 100664510);
			RemindSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, 100664511);
			RemindSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr, 100664512);
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x000B6588 File Offset: 0x000B4788
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x000B65C4 File Offset: 0x000B47C4
		public unsafe bool CloseContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemindSubPanel.NativeMethodInfoPtr_get_CloseContext_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemindSubPanel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000B6604 File Offset: 0x000B4804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30637, XrefRangeEnd = 30652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemindSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000B6640 File Offset: 0x000B4840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30652, XrefRangeEnd = 30653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(string finalMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(finalMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemindSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000B6690 File Offset: 0x000B4890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30653, XrefRangeEnd = 30657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemindSubPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000B66CC File Offset: 0x000B48CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30657, XrefRangeEnd = 30660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemindSubPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemindSubPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemindSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000B6708 File Offset: 0x000B4908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30660, XrefRangeEnd = 30663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemindSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000B673C File Offset: 0x000B493C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30663, XrefRangeEnd = 30666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__7_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemindSubPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00006855 File Offset: 0x00004A55
		public RemindSubPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x000B6770 File Offset: 0x000B4970
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x0000685E File Offset: 0x00004A5E
		public unsafe TextMeshProUGUI m_RemindContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemindSubPanel.NativeFieldInfoPtr_m_RemindContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemindSubPanel.NativeFieldInfoPtr_m_RemindContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x000B67A0 File Offset: 0x000B49A0
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x0000687D File Offset: 0x00004A7D
		public unsafe UIButtonSimple m_RemindConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemindSubPanel.NativeFieldInfoPtr_m_RemindConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemindSubPanel.NativeFieldInfoPtr_m_RemindConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x000B67D0 File Offset: 0x000B49D0
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x0000689C File Offset: 0x00004A9C
		public unsafe UIButtonSimple m_RemindRefuseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemindSubPanel.NativeFieldInfoPtr_m_RemindRefuseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemindSubPanel.NativeFieldInfoPtr_m_RemindRefuseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x000B6800 File Offset: 0x000B4A00
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x000068BB File Offset: 0x00004ABB
		public unsafe bool _CloseContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemindSubPanel.NativeFieldInfoPtr__CloseContext_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemindSubPanel.NativeFieldInfoPtr__CloseContext_k__BackingField)) = value;
			}
		}

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr_m_RemindContext;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeFieldInfoPtr_m_RemindConfirmButton;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr_m_RemindRefuseButton;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr__CloseContext_k__BackingField;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseContext_Public_get_Boolean_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseContext_Private_set_Void_Boolean_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_String_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Private_Void_0;
	}
}
