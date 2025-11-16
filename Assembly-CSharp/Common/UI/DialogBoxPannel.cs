using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace Common.UI
{
	// Token: 0x02000378 RID: 888
	public class DialogBoxPannel : UIPanel
	{
		// Token: 0x06006967 RID: 26983 RVA: 0x001FE3DC File Offset: 0x001FC5DC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogBoxPannel()
		{
			Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DialogBoxPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr);
			DialogBoxPannel.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, "m_Content");
			DialogBoxPannel.NativeFieldInfoPtr_m_ComfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, "m_ComfirmButton");
			DialogBoxPannel.NativeFieldInfoPtr__Context_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, "<Context>k__BackingField");
			DialogBoxPannel.NativeMethodInfoPtr_get_Context_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, 100685179);
			DialogBoxPannel.NativeMethodInfoPtr_set_Context_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, 100685180);
			DialogBoxPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, 100685181);
			DialogBoxPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, 100685182);
			DialogBoxPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, 100685183);
			DialogBoxPannel.NativeMethodInfoPtr_SelectDelayed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, 100685184);
			DialogBoxPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, 100685185);
			DialogBoxPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, 100685186);
			DialogBoxPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr, 100685187);
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x06006968 RID: 26984 RVA: 0x001FE4FC File Offset: 0x001FC6FC
		// (set) Token: 0x06006969 RID: 26985 RVA: 0x001FE534 File Offset: 0x001FC734
		public unsafe string Context
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxPannel.NativeMethodInfoPtr_get_Context_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxPannel.NativeMethodInfoPtr_set_Context_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x0600696A RID: 26986 RVA: 0x001FE578 File Offset: 0x001FC778
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogBoxPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x001FE5C0 File Offset: 0x001FC7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269140, XrefRangeEnd = 269149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogBoxPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x001FE5FC File Offset: 0x001FC7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269149, XrefRangeEnd = 269160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogBoxPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x001FE638 File Offset: 0x001FC838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269160, XrefRangeEnd = 269163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectDelayed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxPannel.NativeMethodInfoPtr_SelectDelayed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x001FE66C File Offset: 0x001FC86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269163, XrefRangeEnd = 269165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogBoxPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x001FE6A8 File Offset: 0x001FC8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogBoxPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x001FE6E4 File Offset: 0x001FC8E4
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogBoxPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogBoxPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x0003905A File Offset: 0x0003725A
		public DialogBoxPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x06006972 RID: 26994 RVA: 0x001FE720 File Offset: 0x001FC920
		// (set) Token: 0x06006973 RID: 26995 RVA: 0x00039063 File Offset: 0x00037263
		public unsafe TMP_Text m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxPannel.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxPannel.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x06006974 RID: 26996 RVA: 0x001FE750 File Offset: 0x001FC950
		// (set) Token: 0x06006975 RID: 26997 RVA: 0x00039082 File Offset: 0x00037282
		public unsafe UIButtonSimple m_ComfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxPannel.NativeFieldInfoPtr_m_ComfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxPannel.NativeFieldInfoPtr_m_ComfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x06006976 RID: 26998 RVA: 0x001FE780 File Offset: 0x001FC980
		// (set) Token: 0x06006977 RID: 26999 RVA: 0x000390A1 File Offset: 0x000372A1
		public unsafe string _Context_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxPannel.NativeFieldInfoPtr__Context_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxPannel.NativeFieldInfoPtr__Context_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040045E3 RID: 17891
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x040045E4 RID: 17892
		private static readonly IntPtr NativeFieldInfoPtr_m_ComfirmButton;

		// Token: 0x040045E5 RID: 17893
		private static readonly IntPtr NativeFieldInfoPtr__Context_k__BackingField;

		// Token: 0x040045E6 RID: 17894
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Private_get_String_0;

		// Token: 0x040045E7 RID: 17895
		private static readonly IntPtr NativeMethodInfoPtr_set_Context_Public_set_Void_String_0;

		// Token: 0x040045E8 RID: 17896
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040045E9 RID: 17897
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040045EA RID: 17898
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040045EB RID: 17899
		private static readonly IntPtr NativeMethodInfoPtr_SelectDelayed_Private_Void_0;

		// Token: 0x040045EC RID: 17900
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040045ED RID: 17901
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040045EE RID: 17902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
