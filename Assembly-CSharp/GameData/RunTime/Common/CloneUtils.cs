using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace GameData.RunTime.Common
{
	// Token: 0x02000228 RID: 552
	public static class CloneUtils : Il2CppSystem.Object
	{
		// Token: 0x060041A2 RID: 16802 RVA: 0x0017F284 File Offset: 0x0017D484
		// Note: this type is marked as 'beforefieldinit'.
		static CloneUtils()
		{
			Il2CppClassPointerStore<CloneUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common", "CloneUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675696);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675697);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675698);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_HashSet_1_T_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675699);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Il2CppReferenceArray_1_List_1_T_Il2CppReferenceArray_1_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675700);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675701);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_String_Tuple_2_String_Il2CppStringArray_Dictionary_2_String_Tuple_2_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675702);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675703);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675704);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675705);
			CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675706);
			CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675707);
			CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675708);
			CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_Nullable_1_T_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675709);
			CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675710);
			CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_Il2CppReferenceArray_1_Nullable_1_T_Il2CppReferenceArray_1_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675711);
			CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675712);
			CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675713);
			CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675714);
			CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675715);
			CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675716);
			CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675717);
			CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, 100675718);
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x0017F480 File Offset: 0x0017D680
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 161840, RefRangeEnd = 161948, XrefRangeStart = 161840, XrefRangeEnd = 161840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> RegularClone<T>(Il2CppArrayBase<T> srcArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_RegularClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x0017F4BC File Offset: 0x0017D6BC
		[CallerCount(1101)]
		[CachedScanResults(RefRangeStart = 161948, RefRangeEnd = 163049, XrefRangeStart = 161948, XrefRangeEnd = 161948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T RegularClone<T>(T value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_RegularClone_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x0017F530 File Offset: 0x0017D730
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 161840, RefRangeEnd = 161948, XrefRangeStart = 161840, XrefRangeEnd = 161948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> RegularClone<T>(List<T> srcArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_RegularClone_Public_Static_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x0017F574 File Offset: 0x0017D774
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 161840, RefRangeEnd = 161948, XrefRangeStart = 161840, XrefRangeEnd = 161948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<T> RegularClone<T>(HashSet<T> srcArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_RegularClone_Public_Static_HashSet_1_T_HashSet_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<T>>(intPtr3) : null;
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x0017F5B8 File Offset: 0x0017D7B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163051, RefRangeEnd = 163052, XrefRangeStart = 163049, XrefRangeEnd = 163051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<List<T>> RegularClone<T>(Il2CppReferenceArray<List<T>> srcArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_RegularClone_Public_Static_Il2CppReferenceArray_1_List_1_T_Il2CppReferenceArray_1_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<T>>>(intPtr3) : null;
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x0017F5FC File Offset: 0x0017D7FC
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 163074, RefRangeEnd = 163124, XrefRangeStart = 163052, XrefRangeEnd = 163074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TValue> RegularClone<TKey, TValue>(Dictionary<TKey, TValue> srcDictionary)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_RegularClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr3) : null;
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x0017F640 File Offset: 0x0017D840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163124, XrefRangeEnd = 163156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Tuple<string, Il2CppStringArray>> RegularClone(Dictionary<string, Tuple<string, Il2CppStringArray>> srcDictionary)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_String_Tuple_2_String_Il2CppStringArray_Dictionary_2_String_Tuple_2_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Tuple<string, Il2CppStringArray>>>(intPtr3) : null;
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x0017F684 File Offset: 0x0017D884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163156, XrefRangeEnd = 163177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>> RegularClone(List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>> srcArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>(intPtr3) : null;
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x0017F6C8 File Offset: 0x0017D8C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163209, RefRangeEnd = 163211, XrefRangeStart = 163177, XrefRangeEnd = 163209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, ValueTuple<int, List<Vector2Int>>> RegularClone(Dictionary<int, ValueTuple<int, List<Vector2Int>>> srcDictionary)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<int, List<Vector2Int>>>>(intPtr3) : null;
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x0017F70C File Offset: 0x0017D90C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 163074, RefRangeEnd = 163124, XrefRangeStart = 163074, XrefRangeEnd = 163124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, List<TValue>> RegularClone<TKey, TValue>(Dictionary<TKey, List<TValue>> srcDictionary)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_RegularClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, List<TValue>>>(intPtr3) : null;
		}

		// Token: 0x060041AD RID: 16813 RVA: 0x0017F750 File Offset: 0x0017D950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163243, RefRangeEnd = 163244, XrefRangeStart = 163211, XrefRangeEnd = 163243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>> RegularClone(Dictionary<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>> srcDictionary)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>>(intPtr3) : null;
		}

		// Token: 0x060041AE RID: 16814 RVA: 0x0017F794 File Offset: 0x0017D994
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 163246, RefRangeEnd = 163251, XrefRangeStart = 163244, XrefRangeEnd = 163246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T DeepClone<T>(T value) where T : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepClone_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x0017F808 File Offset: 0x0017DA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163251, XrefRangeEnd = 163252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T DeepCloneS<T>(T value) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepCloneS_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x0017F87C File Offset: 0x0017DA7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163254, RefRangeEnd = 163255, XrefRangeStart = 163252, XrefRangeEnd = 163254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<T> DeepCloneS<T>(Nullable<T> value) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepCloneS_Public_Static_Nullable_1_T_Nullable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<T>(pointer);
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x0017F8C0 File Offset: 0x0017DAC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 163266, RefRangeEnd = 163272, XrefRangeStart = 163255, XrefRangeEnd = 163266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> DeepClone<T>(Il2CppArrayBase<T> srcArray) where T : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x0017F8FC File Offset: 0x0017DAFC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 163266, RefRangeEnd = 163272, XrefRangeStart = 163266, XrefRangeEnd = 163272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Nullable<T>> DeepCloneS<T>(Il2CppReferenceArray<Nullable<T>> srcArray) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepCloneS_Public_Static_Il2CppReferenceArray_1_Nullable_1_T_Il2CppReferenceArray_1_Nullable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Nullable<T>>>(intPtr3) : null;
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x0017F940 File Offset: 0x0017DB40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 163266, RefRangeEnd = 163272, XrefRangeStart = 163266, XrefRangeEnd = 163272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> DeepClone<T>(List<T> srcArray) where T : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepClone_Public_Static_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x0017F984 File Offset: 0x0017DB84
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 163266, RefRangeEnd = 163272, XrefRangeStart = 163266, XrefRangeEnd = 163272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> DeepCloneS<T>(List<T> srcArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepCloneS_Public_Static_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x0017F9C8 File Offset: 0x0017DBC8
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 163074, RefRangeEnd = 163124, XrefRangeStart = 163074, XrefRangeEnd = 163124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TValue> DeepClone<TKey, TValue>(Dictionary<TKey, TValue> srcDictionary) where TValue : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr3) : null;
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x0017FA0C File Offset: 0x0017DC0C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 163074, RefRangeEnd = 163124, XrefRangeStart = 163074, XrefRangeEnd = 163124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TValue> DeepCloneS<TKey, TValue>(Dictionary<TKey, TValue> srcDictionary) where TValue : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepCloneS_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr3) : null;
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x0017FA50 File Offset: 0x0017DC50
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 163074, RefRangeEnd = 163124, XrefRangeStart = 163074, XrefRangeEnd = 163124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, List<TValue>> DeepClone<TKey, TValue>(Dictionary<TKey, List<TValue>> srcDictionary) where TValue : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, List<TValue>>>(intPtr3) : null;
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x0017FA94 File Offset: 0x0017DC94
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 163074, RefRangeEnd = 163124, XrefRangeStart = 163074, XrefRangeEnd = 163124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, List<TValue>> DeepCloneS<TKey, TValue>(Dictionary<TKey, List<TValue>> srcDictionary) where TValue : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepCloneS_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, List<TValue>>>(intPtr3) : null;
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x0017FAD8 File Offset: 0x0017DCD8
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 163074, RefRangeEnd = 163124, XrefRangeStart = 163074, XrefRangeEnd = 163124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey1, Dictionary<TKey2, TValue>> DeepClone<TKey1, TKey2, TValue>(Dictionary<TKey1, Dictionary<TKey2, TValue>> srcDictionary) where TValue : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(srcDictionary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.MethodInfoStoreGeneric_DeepClone_Public_Static_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_0<TKey1, TKey2, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey1, Dictionary<TKey2, TValue>>>(intPtr3) : null;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x0002387F File Offset: 0x00021A7F
		public CloneUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002C3E RID: 11326
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04002C3F RID: 11327
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_T_T_0;

		// Token: 0x04002C40 RID: 11328
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_List_1_T_List_1_T_0;

		// Token: 0x04002C41 RID: 11329
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_HashSet_1_T_HashSet_1_T_0;

		// Token: 0x04002C42 RID: 11330
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_Il2CppReferenceArray_1_List_1_T_Il2CppReferenceArray_1_List_1_T_0;

		// Token: 0x04002C43 RID: 11331
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0;

		// Token: 0x04002C44 RID: 11332
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_String_Tuple_2_String_Il2CppStringArray_Dictionary_2_String_Tuple_2_String_Il2CppStringArray_0;

		// Token: 0x04002C45 RID: 11333
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0;

		// Token: 0x04002C46 RID: 11334
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0;

		// Token: 0x04002C47 RID: 11335
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0;

		// Token: 0x04002C48 RID: 11336
		private static readonly IntPtr NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0;

		// Token: 0x04002C49 RID: 11337
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_T_T_0;

		// Token: 0x04002C4A RID: 11338
		private static readonly IntPtr NativeMethodInfoPtr_DeepCloneS_Public_Static_T_T_0;

		// Token: 0x04002C4B RID: 11339
		private static readonly IntPtr NativeMethodInfoPtr_DeepCloneS_Public_Static_Nullable_1_T_Nullable_1_T_0;

		// Token: 0x04002C4C RID: 11340
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04002C4D RID: 11341
		private static readonly IntPtr NativeMethodInfoPtr_DeepCloneS_Public_Static_Il2CppReferenceArray_1_Nullable_1_T_Il2CppReferenceArray_1_Nullable_1_T_0;

		// Token: 0x04002C4E RID: 11342
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_List_1_T_List_1_T_0;

		// Token: 0x04002C4F RID: 11343
		private static readonly IntPtr NativeMethodInfoPtr_DeepCloneS_Public_Static_List_1_T_List_1_T_0;

		// Token: 0x04002C50 RID: 11344
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0;

		// Token: 0x04002C51 RID: 11345
		private static readonly IntPtr NativeMethodInfoPtr_DeepCloneS_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0;

		// Token: 0x04002C52 RID: 11346
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0;

		// Token: 0x04002C53 RID: 11347
		private static readonly IntPtr NativeMethodInfoPtr_DeepCloneS_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0;

		// Token: 0x04002C54 RID: 11348
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_0;

		// Token: 0x020009FA RID: 2554
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__5`2")]
		[Serializable]
		public sealed class __c__5<TKey, TValue> : Il2CppSystem.Object
		{
			// Token: 0x0600C347 RID: 49991 RVA: 0x00309E64 File Offset: 0x00308064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__5()
			{
				Il2CppClassPointerStore<CloneUtils.__c__5<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__5`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__5<TKey, TValue>>.NativeClassPtr);
				CloneUtils.__c__5<TKey, TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__5<TKey, TValue>>.NativeClassPtr, "<>9");
				CloneUtils.__c__5<TKey, TValue>.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__5<TKey, TValue>>.NativeClassPtr, "<>9__5_0");
				CloneUtils.__c__5<TKey, TValue>.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__5<TKey, TValue>>.NativeClassPtr, "<>9__5_1");
				CloneUtils.__c__5<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__5<TKey, TValue>>.NativeClassPtr, 100675720);
				CloneUtils.__c__5<TKey, TValue>.NativeMethodInfoPtr__RegularClone_b__5_0_Internal_TKey_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__5<TKey, TValue>>.NativeClassPtr, 100675721);
				CloneUtils.__c__5<TKey, TValue>.NativeMethodInfoPtr__RegularClone_b__5_1_Internal_TValue_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__5<TKey, TValue>>.NativeClassPtr, 100675722);
			}

			// Token: 0x0600C348 RID: 49992 RVA: 0x00309F54 File Offset: 0x00308154
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__5<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__5<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C349 RID: 49993 RVA: 0x00309F90 File Offset: 0x00308190
			[CallerCount(0)]
			public unsafe TKey _RegularClone_b__5_0(KeyValuePair<TKey, TValue> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__5<TKey, TValue>.NativeMethodInfoPtr__RegularClone_b__5_0_Internal_TKey_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}

			// Token: 0x0600C34A RID: 49994 RVA: 0x00309FE0 File Offset: 0x003081E0
			[CallerCount(0)]
			public unsafe TValue _RegularClone_b__5_1(KeyValuePair<TKey, TValue> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__5<TKey, TValue>.NativeMethodInfoPtr__RegularClone_b__5_1_Internal_TValue_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}

			// Token: 0x0600C34B RID: 49995 RVA: 0x000693B3 File Offset: 0x000675B3
			public __c__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F88 RID: 16264
			// (get) Token: 0x0600C34C RID: 49996 RVA: 0x0030A030 File Offset: 0x00308230
			// (set) Token: 0x0600C34D RID: 49997 RVA: 0x000693BC File Offset: 0x000675BC
			public unsafe static CloneUtils.__c__5<TKey, TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__5<TKey, TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__5<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__5<TKey, TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F89 RID: 16265
			// (get) Token: 0x0600C34E RID: 49998 RVA: 0x0030A058 File Offset: 0x00308258
			// (set) Token: 0x0600C34F RID: 49999 RVA: 0x000693CE File Offset: 0x000675CE
			public unsafe static Func<KeyValuePair<TKey, TValue>, TKey> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__5<TKey, TValue>.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, TValue>, TKey>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__5<TKey, TValue>.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F8A RID: 16266
			// (get) Token: 0x0600C350 RID: 50000 RVA: 0x0030A080 File Offset: 0x00308280
			// (set) Token: 0x0600C351 RID: 50001 RVA: 0x000693E0 File Offset: 0x000675E0
			public unsafe static Func<KeyValuePair<TKey, TValue>, TValue> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__5<TKey, TValue>.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, TValue>, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__5<TKey, TValue>.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DAC RID: 32172
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DAD RID: 32173
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04007DAE RID: 32174
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04007DAF RID: 32175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DB0 RID: 32176
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__5_0_Internal_TKey_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x04007DB1 RID: 32177
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__5_1_Internal_TValue_KeyValuePair_2_TKey_TValue_0;
		}

		// Token: 0x020009FB RID: 2555
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C352 RID: 50002 RVA: 0x0030A0A8 File Offset: 0x003082A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr);
				CloneUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, "<>9");
				CloneUtils.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, "<>9__6_0");
				CloneUtils.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, "<>9__6_1");
				CloneUtils.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, "<>9__7_0");
				CloneUtils.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, "<>9__8_0");
				CloneUtils.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, "<>9__8_1");
				CloneUtils.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, "<>9__10_0");
				CloneUtils.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, "<>9__10_1");
				CloneUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, 100675724);
				CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__6_0_Internal_String_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, 100675725);
				CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__6_1_Internal_Tuple_2_String_Il2CppStringArray_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, 100675726);
				CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__7_0_Internal_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, 100675727);
				CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__8_0_Internal_Int32_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, 100675728);
				CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__8_1_Internal_ValueTuple_2_Int32_List_1_Vector2Int_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, 100675729);
				CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__10_0_Internal_Int32_KeyValuePair_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, 100675730);
				CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__10_1_Internal_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_KeyValuePair_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr, 100675731);
			}

			// Token: 0x0600C353 RID: 50003 RVA: 0x0030A214 File Offset: 0x00308414
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C354 RID: 50004 RVA: 0x0030A250 File Offset: 0x00308450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161783, XrefRangeEnd = 161784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _RegularClone_b__6_0(KeyValuePair<string, Tuple<string, Il2CppStringArray>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__6_0_Internal_String_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C355 RID: 50005 RVA: 0x0030A2A0 File Offset: 0x003084A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161784, XrefRangeEnd = 161794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Tuple<string, Il2CppStringArray> _RegularClone_b__6_1(KeyValuePair<string, Tuple<string, Il2CppStringArray>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__6_1_Internal_Tuple_2_String_Il2CppStringArray_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<string, Il2CppStringArray>>(intPtr3) : null;
			}

			// Token: 0x0600C356 RID: 50006 RVA: 0x0030A2F8 File Offset: 0x003084F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161794, XrefRangeEnd = 161802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>> _RegularClone_b__7_0(KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__7_0_Internal_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>(pointer);
			}

			// Token: 0x0600C357 RID: 50007 RVA: 0x0030A348 File Offset: 0x00308548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161802, XrefRangeEnd = 161803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegularClone_b__8_0(KeyValuePair<int, ValueTuple<int, List<Vector2Int>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__8_0_Internal_Int32_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C358 RID: 50008 RVA: 0x0030A39C File Offset: 0x0030859C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161803, XrefRangeEnd = 161810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, List<Vector2Int>> _RegularClone_b__8_1(KeyValuePair<int, ValueTuple<int, List<Vector2Int>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__8_1_Internal_ValueTuple_2_Int32_List_1_Vector2Int_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, List<Vector2Int>>(pointer);
			}

			// Token: 0x0600C359 RID: 50009 RVA: 0x0030A3EC File Offset: 0x003085EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161810, XrefRangeEnd = 161811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RegularClone_b__10_0(KeyValuePair<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__10_0_Internal_Int32_KeyValuePair_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C35A RID: 50010 RVA: 0x0030A440 File Offset: 0x00308640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161811, XrefRangeEnd = 161833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>> _RegularClone_b__10_1(KeyValuePair<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c.NativeMethodInfoPtr__RegularClone_b__10_1_Internal_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_KeyValuePair_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>(intPtr3) : null;
			}

			// Token: 0x0600C35B RID: 50011 RVA: 0x000693F2 File Offset: 0x000675F2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F8B RID: 16267
			// (get) Token: 0x0600C35C RID: 50012 RVA: 0x0030A498 File Offset: 0x00308698
			// (set) Token: 0x0600C35D RID: 50013 RVA: 0x000693FB File Offset: 0x000675FB
			public unsafe static CloneUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F8C RID: 16268
			// (get) Token: 0x0600C35E RID: 50014 RVA: 0x0030A4C0 File Offset: 0x003086C0
			// (set) Token: 0x0600C35F RID: 50015 RVA: 0x0006940D File Offset: 0x0006760D
			public unsafe static Func<KeyValuePair<string, Tuple<string, Il2CppStringArray>>, string> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Tuple<string, Il2CppStringArray>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F8D RID: 16269
			// (get) Token: 0x0600C360 RID: 50016 RVA: 0x0030A4E8 File Offset: 0x003086E8
			// (set) Token: 0x0600C361 RID: 50017 RVA: 0x0006941F File Offset: 0x0006761F
			public unsafe static Func<KeyValuePair<string, Tuple<string, Il2CppStringArray>>, Tuple<string, Il2CppStringArray>> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Tuple<string, Il2CppStringArray>>, Tuple<string, Il2CppStringArray>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F8E RID: 16270
			// (get) Token: 0x0600C362 RID: 50018 RVA: 0x0030A510 File Offset: 0x00308710
			// (set) Token: 0x0600C363 RID: 50019 RVA: 0x00069431 File Offset: 0x00067631
			public unsafe static Func<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>, KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>, KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F8F RID: 16271
			// (get) Token: 0x0600C364 RID: 50020 RVA: 0x0030A538 File Offset: 0x00308738
			// (set) Token: 0x0600C365 RID: 50021 RVA: 0x00069443 File Offset: 0x00067643
			public unsafe static Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, int> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F90 RID: 16272
			// (get) Token: 0x0600C366 RID: 50022 RVA: 0x0030A560 File Offset: 0x00308760
			// (set) Token: 0x0600C367 RID: 50023 RVA: 0x00069455 File Offset: 0x00067655
			public unsafe static Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, ValueTuple<int, List<Vector2Int>>> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, ValueTuple<int, List<Vector2Int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F91 RID: 16273
			// (get) Token: 0x0600C368 RID: 50024 RVA: 0x0030A588 File Offset: 0x00308788
			// (set) Token: 0x0600C369 RID: 50025 RVA: 0x00069467 File Offset: 0x00067667
			public unsafe static Func<KeyValuePair<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>, int> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F92 RID: 16274
			// (get) Token: 0x0600C36A RID: 50026 RVA: 0x0030A5B0 File Offset: 0x003087B0
			// (set) Token: 0x0600C36B RID: 50027 RVA: 0x00069479 File Offset: 0x00067679
			public unsafe static Func<KeyValuePair<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DB2 RID: 32178
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DB3 RID: 32179
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04007DB4 RID: 32180
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04007DB5 RID: 32181
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04007DB6 RID: 32182
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04007DB7 RID: 32183
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04007DB8 RID: 32184
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04007DB9 RID: 32185
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04007DBA RID: 32186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DBB RID: 32187
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__6_0_Internal_String_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0;

			// Token: 0x04007DBC RID: 32188
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__6_1_Internal_Tuple_2_String_Il2CppStringArray_KeyValuePair_2_String_Tuple_2_String_Il2CppStringArray_0;

			// Token: 0x04007DBD RID: 32189
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__7_0_Internal_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0;

			// Token: 0x04007DBE RID: 32190
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__8_0_Internal_Int32_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0;

			// Token: 0x04007DBF RID: 32191
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__8_1_Internal_ValueTuple_2_Int32_List_1_Vector2Int_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0;

			// Token: 0x04007DC0 RID: 32192
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__10_0_Internal_Int32_KeyValuePair_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0;

			// Token: 0x04007DC1 RID: 32193
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__10_1_Internal_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_KeyValuePair_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0;
		}

		// Token: 0x020009FC RID: 2556
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__9`2")]
		[Serializable]
		public sealed class __c__9<TKey, TValue> : Il2CppSystem.Object
		{
			// Token: 0x0600C36C RID: 50028 RVA: 0x0030A5D8 File Offset: 0x003087D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__9()
			{
				Il2CppClassPointerStore<CloneUtils.__c__9<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__9`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__9<TKey, TValue>>.NativeClassPtr);
				CloneUtils.__c__9<TKey, TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__9<TKey, TValue>>.NativeClassPtr, "<>9");
				CloneUtils.__c__9<TKey, TValue>.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__9<TKey, TValue>>.NativeClassPtr, "<>9__9_0");
				CloneUtils.__c__9<TKey, TValue>.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__9<TKey, TValue>>.NativeClassPtr, "<>9__9_1");
				CloneUtils.__c__9<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__9<TKey, TValue>>.NativeClassPtr, 100675733);
				CloneUtils.__c__9<TKey, TValue>.NativeMethodInfoPtr__RegularClone_b__9_0_Internal_TKey_KeyValuePair_2_TKey_List_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__9<TKey, TValue>>.NativeClassPtr, 100675734);
				CloneUtils.__c__9<TKey, TValue>.NativeMethodInfoPtr__RegularClone_b__9_1_Internal_List_1_TValue_KeyValuePair_2_TKey_List_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__9<TKey, TValue>>.NativeClassPtr, 100675735);
			}

			// Token: 0x0600C36D RID: 50029 RVA: 0x0030A6C8 File Offset: 0x003088C8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__9() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__9<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__9<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C36E RID: 50030 RVA: 0x0030A704 File Offset: 0x00308904
			[CallerCount(0)]
			public unsafe TKey _RegularClone_b__9_0(KeyValuePair<TKey, List<TValue>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__9<TKey, TValue>.NativeMethodInfoPtr__RegularClone_b__9_0_Internal_TKey_KeyValuePair_2_TKey_List_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}

			// Token: 0x0600C36F RID: 50031 RVA: 0x0030A754 File Offset: 0x00308954
			[CallerCount(0)]
			public unsafe List<TValue> _RegularClone_b__9_1(KeyValuePair<TKey, List<TValue>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__9<TKey, TValue>.NativeMethodInfoPtr__RegularClone_b__9_1_Internal_List_1_TValue_KeyValuePair_2_TKey_List_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TValue>>(intPtr3) : null;
			}

			// Token: 0x0600C370 RID: 50032 RVA: 0x0006948B File Offset: 0x0006768B
			public __c__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F93 RID: 16275
			// (get) Token: 0x0600C371 RID: 50033 RVA: 0x0030A7AC File Offset: 0x003089AC
			// (set) Token: 0x0600C372 RID: 50034 RVA: 0x00069494 File Offset: 0x00067694
			public unsafe static CloneUtils.__c__9<TKey, TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__9<TKey, TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__9<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__9<TKey, TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F94 RID: 16276
			// (get) Token: 0x0600C373 RID: 50035 RVA: 0x0030A7D4 File Offset: 0x003089D4
			// (set) Token: 0x0600C374 RID: 50036 RVA: 0x000694A6 File Offset: 0x000676A6
			public unsafe static Func<KeyValuePair<TKey, List<TValue>>, TKey> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__9<TKey, TValue>.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, List<TValue>>, TKey>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__9<TKey, TValue>.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F95 RID: 16277
			// (get) Token: 0x0600C375 RID: 50037 RVA: 0x0030A7FC File Offset: 0x003089FC
			// (set) Token: 0x0600C376 RID: 50038 RVA: 0x000694B8 File Offset: 0x000676B8
			public unsafe static Func<KeyValuePair<TKey, List<TValue>>, List<TValue>> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__9<TKey, TValue>.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, List<TValue>>, List<TValue>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__9<TKey, TValue>.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DC2 RID: 32194
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DC3 RID: 32195
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04007DC4 RID: 32196
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04007DC5 RID: 32197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DC6 RID: 32198
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__9_0_Internal_TKey_KeyValuePair_2_TKey_List_1_TValue_0;

			// Token: 0x04007DC7 RID: 32199
			private static readonly IntPtr NativeMethodInfoPtr__RegularClone_b__9_1_Internal_List_1_TValue_KeyValuePair_2_TKey_List_1_TValue_0;
		}

		// Token: 0x020009FD RID: 2557
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__14`1")]
		[Serializable]
		public sealed class __c__14<T> : Il2CppSystem.Object where T : class
		{
			// Token: 0x0600C377 RID: 50039 RVA: 0x0030A824 File Offset: 0x00308A24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__14()
			{
				Il2CppClassPointerStore<CloneUtils.__c__14<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__14`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__14<T>>.NativeClassPtr);
				CloneUtils.__c__14<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__14<T>>.NativeClassPtr, "<>9");
				CloneUtils.__c__14<T>.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__14<T>>.NativeClassPtr, "<>9__14_0");
				CloneUtils.__c__14<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__14<T>>.NativeClassPtr, 100675737);
				CloneUtils.__c__14<T>.NativeMethodInfoPtr__DeepClone_b__14_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__14<T>>.NativeClassPtr, 100675738);
			}

			// Token: 0x0600C378 RID: 50040 RVA: 0x0030A8DC File Offset: 0x00308ADC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__14() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__14<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__14<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C379 RID: 50041 RVA: 0x0030A918 File Offset: 0x00308B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161833, XrefRangeEnd = 161835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _DeepClone_b__14_0(T x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = x;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__14<T>.NativeMethodInfoPtr__DeepClone_b__14_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}

			// Token: 0x0600C37A RID: 50042 RVA: 0x000694CA File Offset: 0x000676CA
			public __c__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F96 RID: 16278
			// (get) Token: 0x0600C37B RID: 50043 RVA: 0x0030A998 File Offset: 0x00308B98
			// (set) Token: 0x0600C37C RID: 50044 RVA: 0x000694D3 File Offset: 0x000676D3
			public unsafe static CloneUtils.__c__14<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__14<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__14<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__14<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F97 RID: 16279
			// (get) Token: 0x0600C37D RID: 50045 RVA: 0x0030A9C0 File Offset: 0x00308BC0
			// (set) Token: 0x0600C37E RID: 50046 RVA: 0x000694E5 File Offset: 0x000676E5
			public unsafe static Func<T, T> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__14<T>.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__14<T>.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DC8 RID: 32200
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DC9 RID: 32201
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04007DCA RID: 32202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DCB RID: 32203
			private static readonly IntPtr NativeMethodInfoPtr__DeepClone_b__14_0_Internal_T_T_0;
		}

		// Token: 0x020009FE RID: 2558
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__15`1")]
		[Serializable]
		public sealed class __c__15<T> : Il2CppSystem.Object where T : new()
		{
			// Token: 0x0600C37F RID: 50047 RVA: 0x0030A9E8 File Offset: 0x00308BE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__15()
			{
				Il2CppClassPointerStore<CloneUtils.__c__15<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__15`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__15<T>>.NativeClassPtr);
				CloneUtils.__c__15<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__15<T>>.NativeClassPtr, "<>9");
				CloneUtils.__c__15<T>.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__15<T>>.NativeClassPtr, "<>9__15_0");
				CloneUtils.__c__15<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__15<T>>.NativeClassPtr, 100675740);
				CloneUtils.__c__15<T>.NativeMethodInfoPtr__DeepCloneS_b__15_0_Internal_Nullable_1_T_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__15<T>>.NativeClassPtr, 100675741);
			}

			// Token: 0x0600C380 RID: 50048 RVA: 0x0030AAA0 File Offset: 0x00308CA0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__15() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__15<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__15<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C381 RID: 50049 RVA: 0x0030AADC File Offset: 0x00308CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161835, XrefRangeEnd = 161837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<T> _DeepCloneS_b__15_0(Nullable<T> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__15<T>.NativeMethodInfoPtr__DeepCloneS_b__15_0_Internal_Nullable_1_T_Nullable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<T>(pointer);
			}

			// Token: 0x0600C382 RID: 50050 RVA: 0x000694F7 File Offset: 0x000676F7
			public __c__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F98 RID: 16280
			// (get) Token: 0x0600C383 RID: 50051 RVA: 0x0030AB2C File Offset: 0x00308D2C
			// (set) Token: 0x0600C384 RID: 50052 RVA: 0x00069500 File Offset: 0x00067700
			public unsafe static CloneUtils.__c__15<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__15<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__15<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__15<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F99 RID: 16281
			// (get) Token: 0x0600C385 RID: 50053 RVA: 0x0030AB54 File Offset: 0x00308D54
			// (set) Token: 0x0600C386 RID: 50054 RVA: 0x00069512 File Offset: 0x00067712
			public unsafe static Func<Nullable<T>, Nullable<T>> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__15<T>.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Nullable<T>, Nullable<T>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__15<T>.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DCC RID: 32204
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DCD RID: 32205
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04007DCE RID: 32206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DCF RID: 32207
			private static readonly IntPtr NativeMethodInfoPtr__DeepCloneS_b__15_0_Internal_Nullable_1_T_Nullable_1_T_0;
		}

		// Token: 0x020009FF RID: 2559
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__16`1")]
		[Serializable]
		public sealed class __c__16<T> : Il2CppSystem.Object where T : class
		{
			// Token: 0x0600C387 RID: 50055 RVA: 0x0030AB7C File Offset: 0x00308D7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__16()
			{
				Il2CppClassPointerStore<CloneUtils.__c__16<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__16`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__16<T>>.NativeClassPtr);
				CloneUtils.__c__16<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__16<T>>.NativeClassPtr, "<>9");
				CloneUtils.__c__16<T>.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__16<T>>.NativeClassPtr, "<>9__16_0");
				CloneUtils.__c__16<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__16<T>>.NativeClassPtr, 100675743);
				CloneUtils.__c__16<T>.NativeMethodInfoPtr__DeepClone_b__16_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__16<T>>.NativeClassPtr, 100675744);
			}

			// Token: 0x0600C388 RID: 50056 RVA: 0x0030AC34 File Offset: 0x00308E34
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__16() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__16<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__16<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C389 RID: 50057 RVA: 0x0030AC70 File Offset: 0x00308E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _DeepClone_b__16_0(T x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = x;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__16<T>.NativeMethodInfoPtr__DeepClone_b__16_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}

			// Token: 0x0600C38A RID: 50058 RVA: 0x00069524 File Offset: 0x00067724
			public __c__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F9A RID: 16282
			// (get) Token: 0x0600C38B RID: 50059 RVA: 0x0030ACF0 File Offset: 0x00308EF0
			// (set) Token: 0x0600C38C RID: 50060 RVA: 0x0006952D File Offset: 0x0006772D
			public unsafe static CloneUtils.__c__16<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__16<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__16<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__16<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F9B RID: 16283
			// (get) Token: 0x0600C38D RID: 50061 RVA: 0x0030AD18 File Offset: 0x00308F18
			// (set) Token: 0x0600C38E RID: 50062 RVA: 0x0006953F File Offset: 0x0006773F
			public unsafe static Func<T, T> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__16<T>.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__16<T>.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DD0 RID: 32208
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DD1 RID: 32209
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04007DD2 RID: 32210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DD3 RID: 32211
			private static readonly IntPtr NativeMethodInfoPtr__DeepClone_b__16_0_Internal_T_T_0;
		}

		// Token: 0x02000A00 RID: 2560
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__17`1")]
		[Serializable]
		public sealed class __c__17<T> : Il2CppSystem.Object
		{
			// Token: 0x0600C38F RID: 50063 RVA: 0x0030AD40 File Offset: 0x00308F40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__17()
			{
				Il2CppClassPointerStore<CloneUtils.__c__17<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__17`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__17<T>>.NativeClassPtr);
				CloneUtils.__c__17<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__17<T>>.NativeClassPtr, "<>9");
				CloneUtils.__c__17<T>.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__17<T>>.NativeClassPtr, "<>9__17_0");
				CloneUtils.__c__17<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__17<T>>.NativeClassPtr, 100675746);
				CloneUtils.__c__17<T>.NativeMethodInfoPtr__DeepCloneS_b__17_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__17<T>>.NativeClassPtr, 100675747);
			}

			// Token: 0x0600C390 RID: 50064 RVA: 0x0030ADF8 File Offset: 0x00308FF8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__17() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__17<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__17<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C391 RID: 50065 RVA: 0x0030AE34 File Offset: 0x00309034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161837, XrefRangeEnd = 161840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _DeepCloneS_b__17_0(T x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = x;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__17<T>.NativeMethodInfoPtr__DeepCloneS_b__17_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}

			// Token: 0x0600C392 RID: 50066 RVA: 0x00069551 File Offset: 0x00067751
			public __c__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F9C RID: 16284
			// (get) Token: 0x0600C393 RID: 50067 RVA: 0x0030AEB4 File Offset: 0x003090B4
			// (set) Token: 0x0600C394 RID: 50068 RVA: 0x0006955A File Offset: 0x0006775A
			public unsafe static CloneUtils.__c__17<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__17<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__17<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__17<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F9D RID: 16285
			// (get) Token: 0x0600C395 RID: 50069 RVA: 0x0030AEDC File Offset: 0x003090DC
			// (set) Token: 0x0600C396 RID: 50070 RVA: 0x0006956C File Offset: 0x0006776C
			public unsafe static Func<T, T> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__17<T>.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__17<T>.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DD4 RID: 32212
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DD5 RID: 32213
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04007DD6 RID: 32214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DD7 RID: 32215
			private static readonly IntPtr NativeMethodInfoPtr__DeepCloneS_b__17_0_Internal_T_T_0;
		}

		// Token: 0x02000A01 RID: 2561
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__18`2")]
		[Serializable]
		public sealed class __c__18<TKey, TValue> : Il2CppSystem.Object where TValue : class
		{
			// Token: 0x0600C397 RID: 50071 RVA: 0x0030AF04 File Offset: 0x00309104
			// Note: this type is marked as 'beforefieldinit'.
			static __c__18()
			{
				Il2CppClassPointerStore<CloneUtils.__c__18<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__18`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__18<TKey, TValue>>.NativeClassPtr);
				CloneUtils.__c__18<TKey, TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__18<TKey, TValue>>.NativeClassPtr, "<>9");
				CloneUtils.__c__18<TKey, TValue>.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__18<TKey, TValue>>.NativeClassPtr, "<>9__18_0");
				CloneUtils.__c__18<TKey, TValue>.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__18<TKey, TValue>>.NativeClassPtr, "<>9__18_1");
				CloneUtils.__c__18<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__18<TKey, TValue>>.NativeClassPtr, 100675749);
				CloneUtils.__c__18<TKey, TValue>.NativeMethodInfoPtr__DeepClone_b__18_0_Internal_TKey_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__18<TKey, TValue>>.NativeClassPtr, 100675750);
				CloneUtils.__c__18<TKey, TValue>.NativeMethodInfoPtr__DeepClone_b__18_1_Internal_TValue_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__18<TKey, TValue>>.NativeClassPtr, 100675751);
			}

			// Token: 0x0600C398 RID: 50072 RVA: 0x0030AFF4 File Offset: 0x003091F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__18() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__18<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__18<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C399 RID: 50073 RVA: 0x0030B030 File Offset: 0x00309230
			[CallerCount(0)]
			public unsafe TKey _DeepClone_b__18_0(KeyValuePair<TKey, TValue> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__18<TKey, TValue>.NativeMethodInfoPtr__DeepClone_b__18_0_Internal_TKey_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}

			// Token: 0x0600C39A RID: 50074 RVA: 0x0030B080 File Offset: 0x00309280
			[CallerCount(0)]
			public unsafe TValue _DeepClone_b__18_1(KeyValuePair<TKey, TValue> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__18<TKey, TValue>.NativeMethodInfoPtr__DeepClone_b__18_1_Internal_TValue_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}

			// Token: 0x0600C39B RID: 50075 RVA: 0x0006957E File Offset: 0x0006777E
			public __c__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F9E RID: 16286
			// (get) Token: 0x0600C39C RID: 50076 RVA: 0x0030B0D0 File Offset: 0x003092D0
			// (set) Token: 0x0600C39D RID: 50077 RVA: 0x00069587 File Offset: 0x00067787
			public unsafe static CloneUtils.__c__18<TKey, TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__18<TKey, TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__18<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__18<TKey, TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F9F RID: 16287
			// (get) Token: 0x0600C39E RID: 50078 RVA: 0x0030B0F8 File Offset: 0x003092F8
			// (set) Token: 0x0600C39F RID: 50079 RVA: 0x00069599 File Offset: 0x00067799
			public unsafe static Func<KeyValuePair<TKey, TValue>, TKey> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__18<TKey, TValue>.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, TValue>, TKey>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__18<TKey, TValue>.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA0 RID: 16288
			// (get) Token: 0x0600C3A0 RID: 50080 RVA: 0x0030B120 File Offset: 0x00309320
			// (set) Token: 0x0600C3A1 RID: 50081 RVA: 0x000695AB File Offset: 0x000677AB
			public unsafe static Func<KeyValuePair<TKey, TValue>, TValue> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__18<TKey, TValue>.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, TValue>, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__18<TKey, TValue>.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DD8 RID: 32216
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DD9 RID: 32217
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04007DDA RID: 32218
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04007DDB RID: 32219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DDC RID: 32220
			private static readonly IntPtr NativeMethodInfoPtr__DeepClone_b__18_0_Internal_TKey_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x04007DDD RID: 32221
			private static readonly IntPtr NativeMethodInfoPtr__DeepClone_b__18_1_Internal_TValue_KeyValuePair_2_TKey_TValue_0;
		}

		// Token: 0x02000A02 RID: 2562
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__19`2")]
		[Serializable]
		public sealed class __c__19<TKey, TValue> : Il2CppSystem.Object where TValue : new()
		{
			// Token: 0x0600C3A2 RID: 50082 RVA: 0x0030B148 File Offset: 0x00309348
			// Note: this type is marked as 'beforefieldinit'.
			static __c__19()
			{
				Il2CppClassPointerStore<CloneUtils.__c__19<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__19`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__19<TKey, TValue>>.NativeClassPtr);
				CloneUtils.__c__19<TKey, TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__19<TKey, TValue>>.NativeClassPtr, "<>9");
				CloneUtils.__c__19<TKey, TValue>.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__19<TKey, TValue>>.NativeClassPtr, "<>9__19_0");
				CloneUtils.__c__19<TKey, TValue>.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__19<TKey, TValue>>.NativeClassPtr, "<>9__19_1");
				CloneUtils.__c__19<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__19<TKey, TValue>>.NativeClassPtr, 100675753);
				CloneUtils.__c__19<TKey, TValue>.NativeMethodInfoPtr__DeepCloneS_b__19_0_Internal_TKey_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__19<TKey, TValue>>.NativeClassPtr, 100675754);
				CloneUtils.__c__19<TKey, TValue>.NativeMethodInfoPtr__DeepCloneS_b__19_1_Internal_TValue_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__19<TKey, TValue>>.NativeClassPtr, 100675755);
			}

			// Token: 0x0600C3A3 RID: 50083 RVA: 0x0030B238 File Offset: 0x00309438
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__19() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__19<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__19<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3A4 RID: 50084 RVA: 0x0030B274 File Offset: 0x00309474
			[CallerCount(0)]
			public unsafe TKey _DeepCloneS_b__19_0(KeyValuePair<TKey, TValue> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__19<TKey, TValue>.NativeMethodInfoPtr__DeepCloneS_b__19_0_Internal_TKey_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}

			// Token: 0x0600C3A5 RID: 50085 RVA: 0x0030B2C4 File Offset: 0x003094C4
			[CallerCount(0)]
			public unsafe TValue _DeepCloneS_b__19_1(KeyValuePair<TKey, TValue> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__19<TKey, TValue>.NativeMethodInfoPtr__DeepCloneS_b__19_1_Internal_TValue_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}

			// Token: 0x0600C3A6 RID: 50086 RVA: 0x000695BD File Offset: 0x000677BD
			public __c__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FA1 RID: 16289
			// (get) Token: 0x0600C3A7 RID: 50087 RVA: 0x0030B314 File Offset: 0x00309514
			// (set) Token: 0x0600C3A8 RID: 50088 RVA: 0x000695C6 File Offset: 0x000677C6
			public unsafe static CloneUtils.__c__19<TKey, TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__19<TKey, TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__19<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__19<TKey, TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA2 RID: 16290
			// (get) Token: 0x0600C3A9 RID: 50089 RVA: 0x0030B33C File Offset: 0x0030953C
			// (set) Token: 0x0600C3AA RID: 50090 RVA: 0x000695D8 File Offset: 0x000677D8
			public unsafe static Func<KeyValuePair<TKey, TValue>, TKey> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__19<TKey, TValue>.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, TValue>, TKey>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__19<TKey, TValue>.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA3 RID: 16291
			// (get) Token: 0x0600C3AB RID: 50091 RVA: 0x0030B364 File Offset: 0x00309564
			// (set) Token: 0x0600C3AC RID: 50092 RVA: 0x000695EA File Offset: 0x000677EA
			public unsafe static Func<KeyValuePair<TKey, TValue>, TValue> __9__19_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__19<TKey, TValue>.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, TValue>, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__19<TKey, TValue>.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DDE RID: 32222
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DDF RID: 32223
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04007DE0 RID: 32224
			private static readonly IntPtr NativeFieldInfoPtr___9__19_1;

			// Token: 0x04007DE1 RID: 32225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DE2 RID: 32226
			private static readonly IntPtr NativeMethodInfoPtr__DeepCloneS_b__19_0_Internal_TKey_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x04007DE3 RID: 32227
			private static readonly IntPtr NativeMethodInfoPtr__DeepCloneS_b__19_1_Internal_TValue_KeyValuePair_2_TKey_TValue_0;
		}

		// Token: 0x02000A03 RID: 2563
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__20`2")]
		[Serializable]
		public sealed class __c__20<TKey, TValue> : Il2CppSystem.Object where TValue : class
		{
			// Token: 0x0600C3AD RID: 50093 RVA: 0x0030B38C File Offset: 0x0030958C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__20()
			{
				Il2CppClassPointerStore<CloneUtils.__c__20<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__20`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__20<TKey, TValue>>.NativeClassPtr);
				CloneUtils.__c__20<TKey, TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__20<TKey, TValue>>.NativeClassPtr, "<>9");
				CloneUtils.__c__20<TKey, TValue>.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__20<TKey, TValue>>.NativeClassPtr, "<>9__20_0");
				CloneUtils.__c__20<TKey, TValue>.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__20<TKey, TValue>>.NativeClassPtr, "<>9__20_1");
				CloneUtils.__c__20<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__20<TKey, TValue>>.NativeClassPtr, 100675757);
				CloneUtils.__c__20<TKey, TValue>.NativeMethodInfoPtr__DeepClone_b__20_0_Internal_TKey_KeyValuePair_2_TKey_List_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__20<TKey, TValue>>.NativeClassPtr, 100675758);
				CloneUtils.__c__20<TKey, TValue>.NativeMethodInfoPtr__DeepClone_b__20_1_Internal_List_1_TValue_KeyValuePair_2_TKey_List_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__20<TKey, TValue>>.NativeClassPtr, 100675759);
			}

			// Token: 0x0600C3AE RID: 50094 RVA: 0x0030B47C File Offset: 0x0030967C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__20() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__20<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__20<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3AF RID: 50095 RVA: 0x0030B4B8 File Offset: 0x003096B8
			[CallerCount(0)]
			public unsafe TKey _DeepClone_b__20_0(KeyValuePair<TKey, List<TValue>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__20<TKey, TValue>.NativeMethodInfoPtr__DeepClone_b__20_0_Internal_TKey_KeyValuePair_2_TKey_List_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}

			// Token: 0x0600C3B0 RID: 50096 RVA: 0x0030B508 File Offset: 0x00309708
			[CallerCount(0)]
			public unsafe List<TValue> _DeepClone_b__20_1(KeyValuePair<TKey, List<TValue>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__20<TKey, TValue>.NativeMethodInfoPtr__DeepClone_b__20_1_Internal_List_1_TValue_KeyValuePair_2_TKey_List_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TValue>>(intPtr3) : null;
			}

			// Token: 0x0600C3B1 RID: 50097 RVA: 0x000695FC File Offset: 0x000677FC
			public __c__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FA4 RID: 16292
			// (get) Token: 0x0600C3B2 RID: 50098 RVA: 0x0030B560 File Offset: 0x00309760
			// (set) Token: 0x0600C3B3 RID: 50099 RVA: 0x00069605 File Offset: 0x00067805
			public unsafe static CloneUtils.__c__20<TKey, TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__20<TKey, TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__20<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__20<TKey, TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA5 RID: 16293
			// (get) Token: 0x0600C3B4 RID: 50100 RVA: 0x0030B588 File Offset: 0x00309788
			// (set) Token: 0x0600C3B5 RID: 50101 RVA: 0x00069617 File Offset: 0x00067817
			public unsafe static Func<KeyValuePair<TKey, List<TValue>>, TKey> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__20<TKey, TValue>.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, List<TValue>>, TKey>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__20<TKey, TValue>.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA6 RID: 16294
			// (get) Token: 0x0600C3B6 RID: 50102 RVA: 0x0030B5B0 File Offset: 0x003097B0
			// (set) Token: 0x0600C3B7 RID: 50103 RVA: 0x00069629 File Offset: 0x00067829
			public unsafe static Func<KeyValuePair<TKey, List<TValue>>, List<TValue>> __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__20<TKey, TValue>.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, List<TValue>>, List<TValue>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__20<TKey, TValue>.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DE4 RID: 32228
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DE5 RID: 32229
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04007DE6 RID: 32230
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x04007DE7 RID: 32231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DE8 RID: 32232
			private static readonly IntPtr NativeMethodInfoPtr__DeepClone_b__20_0_Internal_TKey_KeyValuePair_2_TKey_List_1_TValue_0;

			// Token: 0x04007DE9 RID: 32233
			private static readonly IntPtr NativeMethodInfoPtr__DeepClone_b__20_1_Internal_List_1_TValue_KeyValuePair_2_TKey_List_1_TValue_0;
		}

		// Token: 0x02000A04 RID: 2564
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__21`2")]
		[Serializable]
		public sealed class __c__21<TKey, TValue> : Il2CppSystem.Object where TValue : new()
		{
			// Token: 0x0600C3B8 RID: 50104 RVA: 0x0030B5D8 File Offset: 0x003097D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__21()
			{
				Il2CppClassPointerStore<CloneUtils.__c__21<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__21`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__21<TKey, TValue>>.NativeClassPtr);
				CloneUtils.__c__21<TKey, TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__21<TKey, TValue>>.NativeClassPtr, "<>9");
				CloneUtils.__c__21<TKey, TValue>.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__21<TKey, TValue>>.NativeClassPtr, "<>9__21_0");
				CloneUtils.__c__21<TKey, TValue>.NativeFieldInfoPtr___9__21_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__21<TKey, TValue>>.NativeClassPtr, "<>9__21_1");
				CloneUtils.__c__21<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__21<TKey, TValue>>.NativeClassPtr, 100675761);
				CloneUtils.__c__21<TKey, TValue>.NativeMethodInfoPtr__DeepCloneS_b__21_0_Internal_TKey_KeyValuePair_2_TKey_List_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__21<TKey, TValue>>.NativeClassPtr, 100675762);
				CloneUtils.__c__21<TKey, TValue>.NativeMethodInfoPtr__DeepCloneS_b__21_1_Internal_List_1_TValue_KeyValuePair_2_TKey_List_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__21<TKey, TValue>>.NativeClassPtr, 100675763);
			}

			// Token: 0x0600C3B9 RID: 50105 RVA: 0x0030B6C8 File Offset: 0x003098C8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__21() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__21<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__21<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3BA RID: 50106 RVA: 0x0030B704 File Offset: 0x00309904
			[CallerCount(0)]
			public unsafe TKey _DeepCloneS_b__21_0(KeyValuePair<TKey, List<TValue>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__21<TKey, TValue>.NativeMethodInfoPtr__DeepCloneS_b__21_0_Internal_TKey_KeyValuePair_2_TKey_List_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}

			// Token: 0x0600C3BB RID: 50107 RVA: 0x0030B754 File Offset: 0x00309954
			[CallerCount(0)]
			public unsafe List<TValue> _DeepCloneS_b__21_1(KeyValuePair<TKey, List<TValue>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__21<TKey, TValue>.NativeMethodInfoPtr__DeepCloneS_b__21_1_Internal_List_1_TValue_KeyValuePair_2_TKey_List_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TValue>>(intPtr3) : null;
			}

			// Token: 0x0600C3BC RID: 50108 RVA: 0x0006963B File Offset: 0x0006783B
			public __c__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FA7 RID: 16295
			// (get) Token: 0x0600C3BD RID: 50109 RVA: 0x0030B7AC File Offset: 0x003099AC
			// (set) Token: 0x0600C3BE RID: 50110 RVA: 0x00069644 File Offset: 0x00067844
			public unsafe static CloneUtils.__c__21<TKey, TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__21<TKey, TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__21<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__21<TKey, TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA8 RID: 16296
			// (get) Token: 0x0600C3BF RID: 50111 RVA: 0x0030B7D4 File Offset: 0x003099D4
			// (set) Token: 0x0600C3C0 RID: 50112 RVA: 0x00069656 File Offset: 0x00067856
			public unsafe static Func<KeyValuePair<TKey, List<TValue>>, TKey> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__21<TKey, TValue>.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, List<TValue>>, TKey>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__21<TKey, TValue>.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FA9 RID: 16297
			// (get) Token: 0x0600C3C1 RID: 50113 RVA: 0x0030B7FC File Offset: 0x003099FC
			// (set) Token: 0x0600C3C2 RID: 50114 RVA: 0x00069668 File Offset: 0x00067868
			public unsafe static Func<KeyValuePair<TKey, List<TValue>>, List<TValue>> __9__21_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__21<TKey, TValue>.NativeFieldInfoPtr___9__21_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, List<TValue>>, List<TValue>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__21<TKey, TValue>.NativeFieldInfoPtr___9__21_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DEA RID: 32234
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DEB RID: 32235
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x04007DEC RID: 32236
			private static readonly IntPtr NativeFieldInfoPtr___9__21_1;

			// Token: 0x04007DED RID: 32237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DEE RID: 32238
			private static readonly IntPtr NativeMethodInfoPtr__DeepCloneS_b__21_0_Internal_TKey_KeyValuePair_2_TKey_List_1_TValue_0;

			// Token: 0x04007DEF RID: 32239
			private static readonly IntPtr NativeMethodInfoPtr__DeepCloneS_b__21_1_Internal_List_1_TValue_KeyValuePair_2_TKey_List_1_TValue_0;
		}

		// Token: 0x02000A05 RID: 2565
		[ObfuscatedName("GameData.RunTime.Common.CloneUtils+<>c__22`3")]
		[Serializable]
		public sealed class __c__22<TKey1, TKey2, TValue> : Il2CppSystem.Object where TValue : class
		{
			// Token: 0x0600C3C3 RID: 50115 RVA: 0x0030B824 File Offset: 0x00309A24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__22()
			{
				Il2CppClassPointerStore<CloneUtils.__c__22<TKey1, TKey2, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloneUtils>.NativeClassPtr, "<>c__22`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey1>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey2>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloneUtils.__c__22<TKey1, TKey2, TValue>>.NativeClassPtr);
				CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__22<TKey1, TKey2, TValue>>.NativeClassPtr, "<>9");
				CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__22<TKey1, TKey2, TValue>>.NativeClassPtr, "<>9__22_0");
				CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloneUtils.__c__22<TKey1, TKey2, TValue>>.NativeClassPtr, "<>9__22_1");
				CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__22<TKey1, TKey2, TValue>>.NativeClassPtr, 100675765);
				CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeMethodInfoPtr__DeepClone_b__22_0_Internal_TKey1_KeyValuePair_2_TKey1_Dictionary_2_TKey2_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__22<TKey1, TKey2, TValue>>.NativeClassPtr, 100675766);
				CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeMethodInfoPtr__DeepClone_b__22_1_Internal_Dictionary_2_TKey2_TValue_KeyValuePair_2_TKey1_Dictionary_2_TKey2_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloneUtils.__c__22<TKey1, TKey2, TValue>>.NativeClassPtr, 100675767);
			}

			// Token: 0x0600C3C4 RID: 50116 RVA: 0x0030B928 File Offset: 0x00309B28
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__22() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloneUtils.__c__22<TKey1, TKey2, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3C5 RID: 50117 RVA: 0x0030B964 File Offset: 0x00309B64
			[CallerCount(0)]
			public unsafe TKey1 _DeepClone_b__22_0(KeyValuePair<TKey1, Dictionary<TKey2, TValue>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeMethodInfoPtr__DeepClone_b__22_0_Internal_TKey1_KeyValuePair_2_TKey1_Dictionary_2_TKey2_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey1>(intPtr, false, true);
			}

			// Token: 0x0600C3C6 RID: 50118 RVA: 0x0030B9B4 File Offset: 0x00309BB4
			[CallerCount(0)]
			public unsafe Dictionary<TKey2, TValue> _DeepClone_b__22_1(KeyValuePair<TKey1, Dictionary<TKey2, TValue>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeMethodInfoPtr__DeepClone_b__22_1_Internal_Dictionary_2_TKey2_TValue_KeyValuePair_2_TKey1_Dictionary_2_TKey2_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey2, TValue>>(intPtr3) : null;
			}

			// Token: 0x0600C3C7 RID: 50119 RVA: 0x0006967A File Offset: 0x0006787A
			public __c__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FAA RID: 16298
			// (get) Token: 0x0600C3C8 RID: 50120 RVA: 0x0030BA0C File Offset: 0x00309C0C
			// (set) Token: 0x0600C3C9 RID: 50121 RVA: 0x00069683 File Offset: 0x00067883
			public unsafe static CloneUtils.__c__22<TKey1, TKey2, TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloneUtils.__c__22<TKey1, TKey2, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAB RID: 16299
			// (get) Token: 0x0600C3CA RID: 50122 RVA: 0x0030BA34 File Offset: 0x00309C34
			// (set) Token: 0x0600C3CB RID: 50123 RVA: 0x00069695 File Offset: 0x00067895
			public unsafe static Func<KeyValuePair<TKey1, Dictionary<TKey2, TValue>>, TKey1> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey1, Dictionary<TKey2, TValue>>, TKey1>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAC RID: 16300
			// (get) Token: 0x0600C3CC RID: 50124 RVA: 0x0030BA5C File Offset: 0x00309C5C
			// (set) Token: 0x0600C3CD RID: 50125 RVA: 0x000696A7 File Offset: 0x000678A7
			public unsafe static Func<KeyValuePair<TKey1, Dictionary<TKey2, TValue>>, Dictionary<TKey2, TValue>> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey1, Dictionary<TKey2, TValue>>, Dictionary<TKey2, TValue>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloneUtils.__c__22<TKey1, TKey2, TValue>.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DF0 RID: 32240
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007DF1 RID: 32241
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04007DF2 RID: 32242
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x04007DF3 RID: 32243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007DF4 RID: 32244
			private static readonly IntPtr NativeMethodInfoPtr__DeepClone_b__22_0_Internal_TKey1_KeyValuePair_2_TKey1_Dictionary_2_TKey2_TValue_0;

			// Token: 0x04007DF5 RID: 32245
			private static readonly IntPtr NativeMethodInfoPtr__DeepClone_b__22_1_Internal_Dictionary_2_TKey2_TValue_KeyValuePair_2_TKey1_Dictionary_2_TKey2_TValue_0;
		}

		// Token: 0x02000A06 RID: 2566
		private sealed class MethodInfoStoreGeneric_RegularClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04007DF6 RID: 32246
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A07 RID: 2567
		private sealed class MethodInfoStoreGeneric_RegularClone_Public_Static_T_T_0<T>
		{
			// Token: 0x04007DF7 RID: 32247
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_T_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A08 RID: 2568
		private sealed class MethodInfoStoreGeneric_RegularClone_Public_Static_List_1_T_List_1_T_0<T>
		{
			// Token: 0x04007DF8 RID: 32248
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_List_1_T_List_1_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A09 RID: 2569
		private sealed class MethodInfoStoreGeneric_RegularClone_Public_Static_HashSet_1_T_HashSet_1_T_0<T>
		{
			// Token: 0x04007DF9 RID: 32249
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_HashSet_1_T_HashSet_1_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A0A RID: 2570
		private sealed class MethodInfoStoreGeneric_RegularClone_Public_Static_Il2CppReferenceArray_1_List_1_T_Il2CppReferenceArray_1_List_1_T_0<T>
		{
			// Token: 0x04007DFA RID: 32250
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Il2CppReferenceArray_1_List_1_T_Il2CppReferenceArray_1_List_1_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A0B RID: 2571
		private sealed class MethodInfoStoreGeneric_RegularClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x04007DFB RID: 32251
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A0C RID: 2572
		private sealed class MethodInfoStoreGeneric_RegularClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0<TKey, TValue>
		{
			// Token: 0x04007DFC RID: 32252
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_RegularClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A0D RID: 2573
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_T_T_0<T>
		{
			// Token: 0x04007DFD RID: 32253
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_T_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A0E RID: 2574
		private sealed class MethodInfoStoreGeneric_DeepCloneS_Public_Static_T_T_0<T>
		{
			// Token: 0x04007DFE RID: 32254
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_T_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A0F RID: 2575
		private sealed class MethodInfoStoreGeneric_DeepCloneS_Public_Static_Nullable_1_T_Nullable_1_T_0<T>
		{
			// Token: 0x04007DFF RID: 32255
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_Nullable_1_T_Nullable_1_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A10 RID: 2576
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04007E00 RID: 32256
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A11 RID: 2577
		private sealed class MethodInfoStoreGeneric_DeepCloneS_Public_Static_Il2CppReferenceArray_1_Nullable_1_T_Il2CppReferenceArray_1_Nullable_1_T_0<T>
		{
			// Token: 0x04007E01 RID: 32257
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_Il2CppReferenceArray_1_Nullable_1_T_Il2CppReferenceArray_1_Nullable_1_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A12 RID: 2578
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_List_1_T_List_1_T_0<T>
		{
			// Token: 0x04007E02 RID: 32258
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_List_1_T_List_1_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A13 RID: 2579
		private sealed class MethodInfoStoreGeneric_DeepCloneS_Public_Static_List_1_T_List_1_T_0<T>
		{
			// Token: 0x04007E03 RID: 32259
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_List_1_T_List_1_T_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A14 RID: 2580
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x04007E04 RID: 32260
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A15 RID: 2581
		private sealed class MethodInfoStoreGeneric_DeepCloneS_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x04007E05 RID: 32261
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_Dictionary_2_TKey_TValue_Dictionary_2_TKey_TValue_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A16 RID: 2582
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0<TKey, TValue>
		{
			// Token: 0x04007E06 RID: 32262
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A17 RID: 2583
		private sealed class MethodInfoStoreGeneric_DeepCloneS_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0<TKey, TValue>
		{
			// Token: 0x04007E07 RID: 32263
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepCloneS_Public_Static_Dictionary_2_TKey_List_1_TValue_Dictionary_2_TKey_List_1_TValue_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A18 RID: 2584
		private sealed class MethodInfoStoreGeneric_DeepClone_Public_Static_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_0<TKey1, TKey2, TValue>
		{
			// Token: 0x04007E08 RID: 32264
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CloneUtils.NativeMethodInfoPtr_DeepClone_Public_Static_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_Dictionary_2_TKey1_Dictionary_2_TKey2_TValue_0, Il2CppClassPointerStore<CloneUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}
	}
}
