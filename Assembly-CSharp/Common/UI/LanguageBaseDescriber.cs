using System;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000361 RID: 865
	public class LanguageBaseDescriber : MonoBehaviour
	{
		// Token: 0x060065F6 RID: 26102 RVA: 0x001F2F5C File Offset: 0x001F115C
		// Note: this type is marked as 'beforefieldinit'.
		static LanguageBaseDescriber()
		{
			Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "LanguageBaseDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr);
			LanguageBaseDescriber.NativeFieldInfoPtr_PreloadAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "PreloadAmount");
			LanguageBaseDescriber.NativeFieldInfoPtr_allElementsToHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "allElementsToHide");
			LanguageBaseDescriber.NativeFieldInfoPtr_nullVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "nullVisual");
			LanguageBaseDescriber.NativeFieldInfoPtr_objectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "objectName");
			LanguageBaseDescriber.NativeFieldInfoPtr_objectDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "objectDescription");
			LanguageBaseDescriber.NativeFieldInfoPtr_objectDescription_optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "objectDescription_optional");
			LanguageBaseDescriber.NativeFieldInfoPtr_longDescriptionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "longDescriptionMode");
			LanguageBaseDescriber.NativeFieldInfoPtr_languageBaseVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "languageBaseVisual");
			LanguageBaseDescriber.NativeFieldInfoPtr_OnToggleToLanguageBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "OnToggleToLanguageBase");
			LanguageBaseDescriber.NativeFieldInfoPtr_OnToggleToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, "OnToggleToNull");
			LanguageBaseDescriber.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684658);
			LanguageBaseDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684659);
			LanguageBaseDescriber.NativeMethodInfoPtr_add_OnToggleToLanguageBase_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684660);
			LanguageBaseDescriber.NativeMethodInfoPtr_remove_OnToggleToLanguageBase_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684661);
			LanguageBaseDescriber.NativeMethodInfoPtr_add_OnToggleToNull_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684662);
			LanguageBaseDescriber.NativeMethodInfoPtr_remove_OnToggleToNull_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684663);
			LanguageBaseDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684664);
			LanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_LanguageBase_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684665);
			LanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Void_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684666);
			LanguageBaseDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684667);
			LanguageBaseDescriber.NativeMethodInfoPtr_TrySetDescription_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684668);
			LanguageBaseDescriber.NativeMethodInfoPtr_HideElements_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684669);
			LanguageBaseDescriber.NativeMethodInfoPtr_ToggleVisualForLanguageBase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684670);
			LanguageBaseDescriber.NativeMethodInfoPtr_ToggleVisualForNull_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684671);
			LanguageBaseDescriber.NativeMethodInfoPtr_HideAllChildObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684672);
			LanguageBaseDescriber.NativeMethodInfoPtr_ShowAllChildObjct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684673);
			LanguageBaseDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684674);
			LanguageBaseDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684675);
			LanguageBaseDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr, 100684676);
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x001F31D0 File Offset: 0x001F13D0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 27675, RefRangeEnd = 27686, XrefRangeStart = 27675, XrefRangeEnd = 27686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x001F3204 File Offset: 0x001F1404
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x001F3238 File Offset: 0x001F1438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262957, RefRangeEnd = 262958, XrefRangeStart = 262953, XrefRangeEnd = 262957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnToggleToLanguageBase(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_add_OnToggleToLanguageBase_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x001F327C File Offset: 0x001F147C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262958, XrefRangeEnd = 262962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnToggleToLanguageBase(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_remove_OnToggleToLanguageBase_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x001F32C0 File Offset: 0x001F14C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262966, RefRangeEnd = 262967, XrefRangeStart = 262962, XrefRangeEnd = 262966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnToggleToNull(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_add_OnToggleToNull_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065FC RID: 26108 RVA: 0x001F3304 File Offset: 0x001F1504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262967, XrefRangeEnd = 262971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnToggleToNull(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_remove_OnToggleToNull_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x001F3348 File Offset: 0x001F1548
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPreload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageBaseDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065FE RID: 26110 RVA: 0x001F3384 File Offset: 0x001F1584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262971, XrefRangeEnd = 262972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(LanguageBase detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_LanguageBase_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x001F33E0 File Offset: 0x001F15E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262983, RefRangeEnd = 262988, XrefRangeStart = 262972, XrefRangeEnd = 262983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(LanguageBase detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Void_LanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x001F3424 File Offset: 0x001F1624
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 262995, RefRangeEnd = 262998, XrefRangeStart = 262988, XrefRangeEnd = 262995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x001F3458 File Offset: 0x001F1658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263005, RefRangeEnd = 263007, XrefRangeStart = 262998, XrefRangeEnd = 263005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrySetDescription(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_TrySetDescription_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x001F349C File Offset: 0x001F169C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263008, RefRangeEnd = 263009, XrefRangeStart = 263007, XrefRangeEnd = 263008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageBaseDescriber.NativeMethodInfoPtr_HideElements_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x001F34D8 File Offset: 0x001F16D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263009, XrefRangeEnd = 263011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleVisualForLanguageBase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_ToggleVisualForLanguageBase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x001F350C File Offset: 0x001F170C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263013, RefRangeEnd = 263015, XrefRangeStart = 263011, XrefRangeEnd = 263013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleVisualForNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_ToggleVisualForNull_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x001F3540 File Offset: 0x001F1740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263015, XrefRangeEnd = 263023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideAllChildObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_HideAllChildObject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x001F3574 File Offset: 0x001F1774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263023, XrefRangeEnd = 263031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowAllChildObjct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr_ShowAllChildObjct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x001F35A8 File Offset: 0x001F17A8
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDescriberDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageBaseDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x001F35E4 File Offset: 0x001F17E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 263039, RefRangeEnd = 263042, XrefRangeStart = 263031, XrefRangeEnd = 263039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LanguageBaseDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x001F3620 File Offset: 0x001F1820
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LanguageBaseDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageBaseDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageBaseDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x0003714C File Offset: 0x0003534C
		public LanguageBaseDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x0600660B RID: 26123 RVA: 0x001F365C File Offset: 0x001F185C
		// (set) Token: 0x0600660C RID: 26124 RVA: 0x00037155 File Offset: 0x00035355
		public unsafe static int PreloadAmount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LanguageBaseDescriber.NativeFieldInfoPtr_PreloadAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LanguageBaseDescriber.NativeFieldInfoPtr_PreloadAmount, (void*)(&value));
			}
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x0600660D RID: 26125 RVA: 0x001F3678 File Offset: 0x001F1878
		// (set) Token: 0x0600660E RID: 26126 RVA: 0x00037163 File Offset: 0x00035363
		public unsafe Il2CppReferenceArray<GameObject> allElementsToHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_allElementsToHide);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_allElementsToHide), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x0600660F RID: 26127 RVA: 0x001F36A8 File Offset: 0x001F18A8
		// (set) Token: 0x06006610 RID: 26128 RVA: 0x00037182 File Offset: 0x00035382
		public unsafe Il2CppReferenceArray<GameObject> nullVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_nullVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_nullVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06006611 RID: 26129 RVA: 0x001F36D8 File Offset: 0x001F18D8
		// (set) Token: 0x06006612 RID: 26130 RVA: 0x000371A1 File Offset: 0x000353A1
		public unsafe TextMeshProUGUI objectName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_objectName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_objectName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06006613 RID: 26131 RVA: 0x001F3708 File Offset: 0x001F1908
		// (set) Token: 0x06006614 RID: 26132 RVA: 0x000371C0 File Offset: 0x000353C0
		public unsafe TextMeshProUGUI objectDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_objectDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_objectDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06006615 RID: 26133 RVA: 0x001F3738 File Offset: 0x001F1938
		// (set) Token: 0x06006616 RID: 26134 RVA: 0x000371DF File Offset: 0x000353DF
		public unsafe TextMeshProUGUI objectDescription_optional
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_objectDescription_optional);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_objectDescription_optional), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06006617 RID: 26135 RVA: 0x001F3768 File Offset: 0x001F1968
		// (set) Token: 0x06006618 RID: 26136 RVA: 0x000371FE File Offset: 0x000353FE
		public unsafe bool longDescriptionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_longDescriptionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_longDescriptionMode)) = value;
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x06006619 RID: 26137 RVA: 0x001F3790 File Offset: 0x001F1990
		// (set) Token: 0x0600661A RID: 26138 RVA: 0x00037219 File Offset: 0x00035419
		public unsafe Il2CppReferenceArray<GameObject> languageBaseVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_languageBaseVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_languageBaseVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x0600661B RID: 26139 RVA: 0x001F37C0 File Offset: 0x001F19C0
		// (set) Token: 0x0600661C RID: 26140 RVA: 0x00037238 File Offset: 0x00035438
		public unsafe Action OnToggleToLanguageBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_OnToggleToLanguageBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_OnToggleToLanguageBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x0600661D RID: 26141 RVA: 0x001F37F0 File Offset: 0x001F19F0
		// (set) Token: 0x0600661E RID: 26142 RVA: 0x00037257 File Offset: 0x00035457
		public unsafe Action OnToggleToNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_OnToggleToNull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageBaseDescriber.NativeFieldInfoPtr_OnToggleToNull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043A1 RID: 17313
		private static readonly IntPtr NativeFieldInfoPtr_PreloadAmount;

		// Token: 0x040043A2 RID: 17314
		private static readonly IntPtr NativeFieldInfoPtr_allElementsToHide;

		// Token: 0x040043A3 RID: 17315
		private static readonly IntPtr NativeFieldInfoPtr_nullVisual;

		// Token: 0x040043A4 RID: 17316
		private static readonly IntPtr NativeFieldInfoPtr_objectName;

		// Token: 0x040043A5 RID: 17317
		private static readonly IntPtr NativeFieldInfoPtr_objectDescription;

		// Token: 0x040043A6 RID: 17318
		private static readonly IntPtr NativeFieldInfoPtr_objectDescription_optional;

		// Token: 0x040043A7 RID: 17319
		private static readonly IntPtr NativeFieldInfoPtr_longDescriptionMode;

		// Token: 0x040043A8 RID: 17320
		private static readonly IntPtr NativeFieldInfoPtr_languageBaseVisual;

		// Token: 0x040043A9 RID: 17321
		private static readonly IntPtr NativeFieldInfoPtr_OnToggleToLanguageBase;

		// Token: 0x040043AA RID: 17322
		private static readonly IntPtr NativeFieldInfoPtr_OnToggleToNull;

		// Token: 0x040043AB RID: 17323
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040043AC RID: 17324
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040043AD RID: 17325
		private static readonly IntPtr NativeMethodInfoPtr_add_OnToggleToLanguageBase_Public_add_Void_Action_0;

		// Token: 0x040043AE RID: 17326
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnToggleToLanguageBase_Public_rem_Void_Action_0;

		// Token: 0x040043AF RID: 17327
		private static readonly IntPtr NativeMethodInfoPtr_add_OnToggleToNull_Public_add_Void_Action_0;

		// Token: 0x040043B0 RID: 17328
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnToggleToNull_Public_rem_Void_Action_0;

		// Token: 0x040043B1 RID: 17329
		private static readonly IntPtr NativeMethodInfoPtr_OnPreload_Protected_Virtual_New_Void_0;

		// Token: 0x040043B2 RID: 17330
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_LanguageBase_CancellationToken_0;

		// Token: 0x040043B3 RID: 17331
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_LanguageBase_0;

		// Token: 0x040043B4 RID: 17332
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0;

		// Token: 0x040043B5 RID: 17333
		private static readonly IntPtr NativeMethodInfoPtr_TrySetDescription_Private_Void_String_0;

		// Token: 0x040043B6 RID: 17334
		private static readonly IntPtr NativeMethodInfoPtr_HideElements_Protected_Virtual_New_Void_0;

		// Token: 0x040043B7 RID: 17335
		private static readonly IntPtr NativeMethodInfoPtr_ToggleVisualForLanguageBase_Public_Void_0;

		// Token: 0x040043B8 RID: 17336
		private static readonly IntPtr NativeMethodInfoPtr_ToggleVisualForNull_Public_Void_0;

		// Token: 0x040043B9 RID: 17337
		private static readonly IntPtr NativeMethodInfoPtr_HideAllChildObject_Public_Void_0;

		// Token: 0x040043BA RID: 17338
		private static readonly IntPtr NativeMethodInfoPtr_ShowAllChildObjct_Public_Void_0;

		// Token: 0x040043BB RID: 17339
		private static readonly IntPtr NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_New_Void_0;

		// Token: 0x040043BC RID: 17340
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040043BD RID: 17341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
