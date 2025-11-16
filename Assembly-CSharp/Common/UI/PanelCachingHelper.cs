using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Common.UI
{
	// Token: 0x02000354 RID: 852
	public static class PanelCachingHelper : Object
	{
		// Token: 0x0600648B RID: 25739 RVA: 0x001EE1A0 File Offset: 0x001EC3A0
		// Note: this type is marked as 'beforefieldinit'.
		static PanelCachingHelper()
		{
			Il2CppClassPointerStore<PanelCachingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "PanelCachingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelCachingHelper>.NativeClassPtr);
			PanelCachingHelper.NativeMethodInfoPtr_PrepareOrGetTempPanelInstance_Public_Static_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelCachingHelper>.NativeClassPtr, 100684377);
			PanelCachingHelper.NativeMethodInfoPtr_PrepareBufferedPanelWithRecord_Public_Static_T_T_Action_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelCachingHelper>.NativeClassPtr, 100684378);
			PanelCachingHelper.NativeMethodInfoPtr_PreBufferPanelWithRecord_Public_Static_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelCachingHelper>.NativeClassPtr, 100684379);
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x001EE20C File Offset: 0x001EC40C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 258693, RefRangeEnd = 258701, XrefRangeStart = 258689, XrefRangeEnd = 258693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T PrepareOrGetTempPanelInstance<T>(this T panelParent, string bufferPanelLabel = null) where T : UIPanelBaseImpl
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelParent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelParent;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bufferPanelLabel);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PanelCachingHelper.MethodInfoStoreGeneric_PrepareOrGetTempPanelInstance_Public_Static_T_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x001EE294 File Offset: 0x001EC494
		[CallerCount(80)]
		[CachedScanResults(RefRangeStart = 258704, RefRangeEnd = 258784, XrefRangeStart = 258701, XrefRangeEnd = 258704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T PrepareBufferedPanelWithRecord<T>(this T panelParent, Action<T> preInitializeCallback = null, string bufferPanelLabel = null) where T : UIPanelBaseImpl
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelParent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelParent;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preInitializeCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bufferPanelLabel);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PanelCachingHelper.MethodInfoStoreGeneric_PrepareBufferedPanelWithRecord_Public_Static_T_T_Action_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x001EE32C File Offset: 0x001EC52C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 258788, RefRangeEnd = 258796, XrefRangeStart = 258784, XrefRangeEnd = 258788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T PreBufferPanelWithRecord<T>(this T panelParent, string bufferPanelLabel = null) where T : UIPanelBaseImpl
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelParent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelParent;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bufferPanelLabel);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PanelCachingHelper.MethodInfoStoreGeneric_PreBufferPanelWithRecord_Public_Static_T_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x00036674 File Offset: 0x00034874
		public PanelCachingHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040042A5 RID: 17061
		private static readonly IntPtr NativeMethodInfoPtr_PrepareOrGetTempPanelInstance_Public_Static_T_T_String_0;

		// Token: 0x040042A6 RID: 17062
		private static readonly IntPtr NativeMethodInfoPtr_PrepareBufferedPanelWithRecord_Public_Static_T_T_Action_1_T_String_0;

		// Token: 0x040042A7 RID: 17063
		private static readonly IntPtr NativeMethodInfoPtr_PreBufferPanelWithRecord_Public_Static_T_T_String_0;

		// Token: 0x02000E09 RID: 3593
		private sealed class MethodInfoStoreGeneric_PrepareOrGetTempPanelInstance_Public_Static_T_T_String_0<T>
		{
			// Token: 0x0400A449 RID: 42057
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PanelCachingHelper.NativeMethodInfoPtr_PrepareOrGetTempPanelInstance_Public_Static_T_T_String_0, Il2CppClassPointerStore<PanelCachingHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E0A RID: 3594
		private sealed class MethodInfoStoreGeneric_PrepareBufferedPanelWithRecord_Public_Static_T_T_Action_1_T_String_0<T>
		{
			// Token: 0x0400A44A RID: 42058
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PanelCachingHelper.NativeMethodInfoPtr_PrepareBufferedPanelWithRecord_Public_Static_T_T_Action_1_T_String_0, Il2CppClassPointerStore<PanelCachingHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E0B RID: 3595
		private sealed class MethodInfoStoreGeneric_PreBufferPanelWithRecord_Public_Static_T_T_String_0<T>
		{
			// Token: 0x0400A44B RID: 42059
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PanelCachingHelper.NativeMethodInfoPtr_PreBufferPanelWithRecord_Public_Static_T_T_String_0, Il2CppClassPointerStore<PanelCachingHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
