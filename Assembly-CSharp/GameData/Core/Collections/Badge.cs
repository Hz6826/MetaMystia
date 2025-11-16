using System;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections
{
	// Token: 0x0200023C RID: 572
	[Serializable]
	public class Badge : NonTradableObjectBase
	{
		// Token: 0x060047A0 RID: 18336 RVA: 0x001969E0 File Offset: 0x00194BE0
		// Note: this type is marked as 'beforefieldinit'.
		static Badge()
		{
			Il2CppClassPointerStore<Badge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "Badge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Badge>.NativeClassPtr);
			Badge.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Badge>.NativeClassPtr, 100677646);
			Badge.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Badge>.NativeClassPtr, 100677647);
			Badge.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Badge>.NativeClassPtr, 100677648);
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x00196A4C File Offset: 0x00194C4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 189502, RefRangeEnd = 189505, XrefRangeStart = 189501, XrefRangeEnd = 189502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Badge(int id) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Badge>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Badge.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x00196A94 File Offset: 0x00194C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189505, XrefRangeEnd = 189511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Badge.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x00196AE0 File Offset: 0x00194CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189511, XrefRangeEnd = 189512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjectLanguageBase GetText(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Badge.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x00024E2E File Offset: 0x0002302E
		public Badge(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003133 RID: 12595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003134 RID: 12596
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x04003135 RID: 12597
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0;
	}
}
