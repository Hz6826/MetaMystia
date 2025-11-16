using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AssetHandleUtility;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000362 RID: 866
	public static class DescriberHelper : Il2CppSystem.Object
	{
		// Token: 0x0600661F RID: 26143 RVA: 0x001F3820 File Offset: 0x001F1A20
		// Note: this type is marked as 'beforefieldinit'.
		static DescriberHelper()
		{
			Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DescriberHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr);
			DescriberHelper.NativeFieldInfoPtr_s_SingleElementArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, "s_SingleElementArray");
			DescriberHelper.NativeMethodInfoPtr_SpawnConditioned_Private_Static_Void_GameObject_Transform_IReadOnlyList_1_Int32_Func_2_Int32_String_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, 100684677);
			DescriberHelper.NativeMethodInfoPtr_PrintGuestTags_Public_Static_Void_GameObject_Transform_List_1_Int32_IReadOnlyList_1_Int32_Boolean_String_List_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, 100684678);
			DescriberHelper.NativeMethodInfoPtr_AssignImageSpriteAsync_Public_Static_Void_Image_UniTask_1_IAssetHandle_1_Sprite_CancellationToken_Action_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, 100684679);
			DescriberHelper.NativeMethodInfoPtr_AssignImageSpriteImpl_Private_Static_UniTaskVoid_Image_UniTask_1_IAssetHandle_1_Sprite_CancellationToken_Action_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, 100684680);
			DescriberHelper.NativeMethodInfoPtr_GetMultiplyImageSizePostProcessor_Public_Static_Action_1_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, 100684681);
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x001F38C8 File Offset: 0x001F1AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263163, RefRangeEnd = 263164, XrefRangeStart = 263140, XrefRangeEnd = 263163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpawnConditioned(GameObject gameObject, Transform field, IReadOnlyList<int> tags, Func<int, string> getLangHandler, List<GameObject> instances)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tags);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getLangHandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instances);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.NativeMethodInfoPtr_SpawnConditioned_Private_Static_Void_GameObject_Transform_IReadOnlyList_1_Int32_Func_2_Int32_String_List_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x001F3948 File Offset: 0x001F1B48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 263187, RefRangeEnd = 263191, XrefRangeStart = 263164, XrefRangeEnd = 263187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrintGuestTags(GameObject prefab, Transform field, List<int> collectionBuffer, IReadOnlyList<int> tags, bool all, string allKey, List<GameObject> instances, bool isFoodTag)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tags);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref all;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(allKey);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instances);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFoodTag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.NativeMethodInfoPtr_PrintGuestTags_Public_Static_Void_GameObject_Transform_List_1_Int32_IReadOnlyList_1_Int32_Boolean_String_List_1_GameObject_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x001F39F8 File Offset: 0x001F1BF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 263203, RefRangeEnd = 263208, XrefRangeStart = 263191, XrefRangeEnd = 263203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignImageSpriteAsync(this Image imageComponent, UniTask<IAssetHandle<Sprite>> spriteHandle, CancellationToken cancellationToken, Action<Image> postProcessCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageComponent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(spriteHandle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postProcessCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.NativeMethodInfoPtr_AssignImageSpriteAsync_Public_Static_Void_Image_UniTask_1_IAssetHandle_1_Sprite_CancellationToken_Action_1_Image_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x001F3A70 File Offset: 0x001F1C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263208, XrefRangeEnd = 263216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTaskVoid AssignImageSpriteImpl(Image imageComponent, UniTask<IAssetHandle<Sprite>> spriteHandle, CancellationToken cancellationToken, Action<Image> postProcessCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageComponent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(spriteHandle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postProcessCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.NativeMethodInfoPtr_AssignImageSpriteImpl_Private_Static_UniTaskVoid_Image_UniTask_1_IAssetHandle_1_Sprite_CancellationToken_Action_1_Image_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x001F3AF4 File Offset: 0x001F1CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263216, XrefRangeEnd = 263226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action<Image> GetMultiplyImageSizePostProcessor(int multiplier)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.NativeMethodInfoPtr_GetMultiplyImageSizePostProcessor_Public_Static_Action_1_Image_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr3) : null;
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x00037276 File Offset: 0x00035476
		public DescriberHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06006626 RID: 26150 RVA: 0x001F3B34 File Offset: 0x001F1D34
		// (set) Token: 0x06006627 RID: 26151 RVA: 0x0003727F File Offset: 0x0003547F
		public unsafe static Il2CppStructArray<int> s_SingleElementArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DescriberHelper.NativeFieldInfoPtr_s_SingleElementArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DescriberHelper.NativeFieldInfoPtr_s_SingleElementArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043BE RID: 17342
		private static readonly IntPtr NativeFieldInfoPtr_s_SingleElementArray;

		// Token: 0x040043BF RID: 17343
		private static readonly IntPtr NativeMethodInfoPtr_SpawnConditioned_Private_Static_Void_GameObject_Transform_IReadOnlyList_1_Int32_Func_2_Int32_String_List_1_GameObject_0;

		// Token: 0x040043C0 RID: 17344
		private static readonly IntPtr NativeMethodInfoPtr_PrintGuestTags_Public_Static_Void_GameObject_Transform_List_1_Int32_IReadOnlyList_1_Int32_Boolean_String_List_1_GameObject_Boolean_0;

		// Token: 0x040043C1 RID: 17345
		private static readonly IntPtr NativeMethodInfoPtr_AssignImageSpriteAsync_Public_Static_Void_Image_UniTask_1_IAssetHandle_1_Sprite_CancellationToken_Action_1_Image_0;

		// Token: 0x040043C2 RID: 17346
		private static readonly IntPtr NativeMethodInfoPtr_AssignImageSpriteImpl_Private_Static_UniTaskVoid_Image_UniTask_1_IAssetHandle_1_Sprite_CancellationToken_Action_1_Image_0;

		// Token: 0x040043C3 RID: 17347
		private static readonly IntPtr NativeMethodInfoPtr_GetMultiplyImageSizePostProcessor_Public_Static_Action_1_Image_Int32_0;

		// Token: 0x02000E45 RID: 3653
		[ObfuscatedName("Common.UI.DescriberHelper+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			// Token: 0x0601055B RID: 66907 RVA: 0x003CC42C File Offset: 0x003CA62C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_0>.NativeClassPtr);
				DescriberHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_getLangHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_0>.NativeClassPtr, "getLangHandler");
				DescriberHelper.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_0>.NativeClassPtr, 100684683);
				DescriberHelper.__c__DisplayClass1_0.NativeMethodInfoPtr__SpawnConditioned_b__1_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_0>.NativeClassPtr, 100684684);
			}

			// Token: 0x0601055C RID: 66908 RVA: 0x003CC494 File Offset: 0x003CA694
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601055D RID: 66909 RVA: 0x003CC4D0 File Offset: 0x003CA6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263042, XrefRangeEnd = 263055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SpawnConditioned_b__1(UIElementCluster interactableBase, int tagId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interactableBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass1_0.NativeMethodInfoPtr__SpawnConditioned_b__1_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601055E RID: 66910 RVA: 0x0008E857 File Offset: 0x0008CA57
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005566 RID: 21862
			// (get) Token: 0x0601055F RID: 66911 RVA: 0x003CC520 File Offset: 0x003CA720
			// (set) Token: 0x06010560 RID: 66912 RVA: 0x0008E860 File Offset: 0x0008CA60
			public unsafe Func<int, string> getLangHandler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_getLangHandler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass1_0.NativeFieldInfoPtr_getLangHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A591 RID: 42385
			private static readonly IntPtr NativeFieldInfoPtr_getLangHandler;

			// Token: 0x0400A592 RID: 42386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A593 RID: 42387
			private static readonly IntPtr NativeMethodInfoPtr__SpawnConditioned_b__1_Internal_Void_UIElementCluster_Int32_0;
		}

		// Token: 0x02000E46 RID: 3654
		[ObfuscatedName("Common.UI.DescriberHelper+<>c__DisplayClass1_1")]
		public sealed class __c__DisplayClass1_1 : Il2CppSystem.Object
		{
			// Token: 0x06010561 RID: 66913 RVA: 0x003CC550 File Offset: 0x003CA750
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_1()
			{
				Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, "<>c__DisplayClass1_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_1>.NativeClassPtr);
				DescriberHelper.__c__DisplayClass1_1.NativeFieldInfoPtr_tagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_1>.NativeClassPtr, "tagId");
				DescriberHelper.__c__DisplayClass1_1.NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_1>.NativeClassPtr, "CS$<>8__locals1");
				DescriberHelper.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_1>.NativeClassPtr, 100684685);
				DescriberHelper.__c__DisplayClass1_1.NativeMethodInfoPtr__SpawnConditioned_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_1>.NativeClassPtr, 100684686);
			}

			// Token: 0x06010562 RID: 66914 RVA: 0x003CC5CC File Offset: 0x003CA7CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass1_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010563 RID: 66915 RVA: 0x003CC608 File Offset: 0x003CA808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263055, XrefRangeEnd = 263056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SpawnConditioned_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass1_1.NativeMethodInfoPtr__SpawnConditioned_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010564 RID: 66916 RVA: 0x0008E87F File Offset: 0x0008CA7F
			public __c__DisplayClass1_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005567 RID: 21863
			// (get) Token: 0x06010565 RID: 66917 RVA: 0x003CC64C File Offset: 0x003CA84C
			// (set) Token: 0x06010566 RID: 66918 RVA: 0x0008E888 File Offset: 0x0008CA88
			public unsafe int tagId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass1_1.NativeFieldInfoPtr_tagId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass1_1.NativeFieldInfoPtr_tagId)) = value;
				}
			}

			// Token: 0x17005568 RID: 21864
			// (get) Token: 0x06010567 RID: 66919 RVA: 0x003CC674 File Offset: 0x003CA874
			// (set) Token: 0x06010568 RID: 66920 RVA: 0x0008E8A3 File Offset: 0x0008CAA3
			public unsafe DescriberHelper.__c__DisplayClass1_0 field_Public___c__DisplayClass1_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass1_1.NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescriberHelper.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass1_1.NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A594 RID: 42388
			private static readonly IntPtr NativeFieldInfoPtr_tagId;

			// Token: 0x0400A595 RID: 42389
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0;

			// Token: 0x0400A596 RID: 42390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A597 RID: 42391
			private static readonly IntPtr NativeMethodInfoPtr__SpawnConditioned_b__3_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E47 RID: 3655
		[ObfuscatedName("Common.UI.DescriberHelper+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010569 RID: 66921 RVA: 0x003CC6A4 File Offset: 0x003CA8A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DescriberHelper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriberHelper.__c>.NativeClassPtr);
				DescriberHelper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c>.NativeClassPtr, "<>9");
				DescriberHelper.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c>.NativeClassPtr, "<>9__1_2");
				DescriberHelper.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c>.NativeClassPtr, "<>9__1_0");
				DescriberHelper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c>.NativeClassPtr, 100684688);
				DescriberHelper.__c.NativeMethodInfoPtr__SpawnConditioned_b__1_0_Internal_Void_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c>.NativeClassPtr, 100684689);
				DescriberHelper.__c.NativeMethodInfoPtr__SpawnConditioned_b__1_2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c>.NativeClassPtr, 100684690);
			}

			// Token: 0x0601056A RID: 66922 RVA: 0x003CC748 File Offset: 0x003CA948
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriberHelper.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601056B RID: 66923 RVA: 0x003CC784 File Offset: 0x003CA984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263056, XrefRangeEnd = 263073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SpawnConditioned_b__1_0(UIElementCluster interactableBase, int tagId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interactableBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c.NativeMethodInfoPtr__SpawnConditioned_b__1_0_Internal_Void_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601056C RID: 66924 RVA: 0x003CC7D4 File Offset: 0x003CA9D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263073, XrefRangeEnd = 263076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SpawnConditioned_b__1_2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c.NativeMethodInfoPtr__SpawnConditioned_b__1_2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601056D RID: 66925 RVA: 0x0008E8C2 File Offset: 0x0008CAC2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005569 RID: 21865
			// (get) Token: 0x0601056E RID: 66926 RVA: 0x003CC818 File Offset: 0x003CAA18
			// (set) Token: 0x0601056F RID: 66927 RVA: 0x0008E8CB File Offset: 0x0008CACB
			public unsafe static DescriberHelper.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DescriberHelper.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescriberHelper.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DescriberHelper.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700556A RID: 21866
			// (get) Token: 0x06010570 RID: 66928 RVA: 0x003CC840 File Offset: 0x003CAA40
			// (set) Token: 0x06010571 RID: 66929 RVA: 0x0008E8DD File Offset: 0x0008CADD
			public unsafe static Action<TextMeshProUGUI> __9__1_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DescriberHelper.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DescriberHelper.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700556B RID: 21867
			// (get) Token: 0x06010572 RID: 66930 RVA: 0x003CC868 File Offset: 0x003CAA68
			// (set) Token: 0x06010573 RID: 66931 RVA: 0x0008E8EF File Offset: 0x0008CAEF
			public unsafe static Action<UIElementCluster, int> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DescriberHelper.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DescriberHelper.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A598 RID: 42392
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A599 RID: 42393
			private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

			// Token: 0x0400A59A RID: 42394
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400A59B RID: 42395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A59C RID: 42396
			private static readonly IntPtr NativeMethodInfoPtr__SpawnConditioned_b__1_0_Internal_Void_UIElementCluster_Int32_0;

			// Token: 0x0400A59D RID: 42397
			private static readonly IntPtr NativeMethodInfoPtr__SpawnConditioned_b__1_2_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E48 RID: 3656
		[ObfuscatedName("Common.UI.DescriberHelper+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x06010574 RID: 66932 RVA: 0x003CC890 File Offset: 0x003CAA90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass2_0>.NativeClassPtr);
				DescriberHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_allKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass2_0>.NativeClassPtr, "allKey");
				DescriberHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_isFoodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass2_0>.NativeClassPtr, "isFoodTag");
				DescriberHelper.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass2_0>.NativeClassPtr, 100684691);
				DescriberHelper.__c__DisplayClass2_0.NativeMethodInfoPtr__PrintGuestTags_b__0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass2_0>.NativeClassPtr, 100684692);
			}

			// Token: 0x06010575 RID: 66933 RVA: 0x003CC90C File Offset: 0x003CAB0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010576 RID: 66934 RVA: 0x003CC948 File Offset: 0x003CAB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263076, XrefRangeEnd = 263078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _PrintGuestTags_b__0(int tagId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref tagId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass2_0.NativeMethodInfoPtr__PrintGuestTags_b__0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010577 RID: 66935 RVA: 0x0008E901 File Offset: 0x0008CB01
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700556C RID: 21868
			// (get) Token: 0x06010578 RID: 66936 RVA: 0x003CC98C File Offset: 0x003CAB8C
			// (set) Token: 0x06010579 RID: 66937 RVA: 0x0008E90A File Offset: 0x0008CB0A
			public unsafe string allKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_allKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_allKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700556D RID: 21869
			// (get) Token: 0x0601057A RID: 66938 RVA: 0x003CC9B4 File Offset: 0x003CABB4
			// (set) Token: 0x0601057B RID: 66939 RVA: 0x0008E929 File Offset: 0x0008CB29
			public unsafe bool isFoodTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_isFoodTag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass2_0.NativeFieldInfoPtr_isFoodTag)) = value;
				}
			}

			// Token: 0x0400A59E RID: 42398
			private static readonly IntPtr NativeFieldInfoPtr_allKey;

			// Token: 0x0400A59F RID: 42399
			private static readonly IntPtr NativeFieldInfoPtr_isFoodTag;

			// Token: 0x0400A5A0 RID: 42400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5A1 RID: 42401
			private static readonly IntPtr NativeMethodInfoPtr__PrintGuestTags_b__0_Internal_String_Int32_0;
		}

		// Token: 0x02000E49 RID: 3657
		[ObfuscatedName("Common.UI.DescriberHelper+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0601057C RID: 66940 RVA: 0x003CC9DC File Offset: 0x003CABDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass4_0>.NativeClassPtr);
				DescriberHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_imageComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass4_0>.NativeClassPtr, "imageComponent");
				DescriberHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_assetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass4_0>.NativeClassPtr, "assetHandle");
				DescriberHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass4_0>.NativeClassPtr, 100684693);
				DescriberHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__AssignImageSpriteImpl_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass4_0>.NativeClassPtr, 100684694);
			}

			// Token: 0x0601057D RID: 66941 RVA: 0x003CCA58 File Offset: 0x003CAC58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601057E RID: 66942 RVA: 0x003CCA94 File Offset: 0x003CAC94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263078, XrefRangeEnd = 263084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AssignImageSpriteImpl_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass4_0.NativeMethodInfoPtr__AssignImageSpriteImpl_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601057F RID: 66943 RVA: 0x0008E944 File Offset: 0x0008CB44
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700556E RID: 21870
			// (get) Token: 0x06010580 RID: 66944 RVA: 0x003CCAC8 File Offset: 0x003CACC8
			// (set) Token: 0x06010581 RID: 66945 RVA: 0x0008E94D File Offset: 0x0008CB4D
			public unsafe Image imageComponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_imageComponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_imageComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700556F RID: 21871
			// (get) Token: 0x06010582 RID: 66946 RVA: 0x003CCAF8 File Offset: 0x003CACF8
			// (set) Token: 0x06010583 RID: 66947 RVA: 0x0008E96C File Offset: 0x0008CB6C
			public unsafe IAssetHandle<Sprite> assetHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_assetHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass4_0.NativeFieldInfoPtr_assetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5A2 RID: 42402
			private static readonly IntPtr NativeFieldInfoPtr_imageComponent;

			// Token: 0x0400A5A3 RID: 42403
			private static readonly IntPtr NativeFieldInfoPtr_assetHandle;

			// Token: 0x0400A5A4 RID: 42404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5A5 RID: 42405
			private static readonly IntPtr NativeMethodInfoPtr__AssignImageSpriteImpl_b__0_Internal_Void_0;
		}

		// Token: 0x02000E4A RID: 3658
		[ObfuscatedName("Common.UI.DescriberHelper+<AssignImageSpriteImpl>d__4")]
		public sealed class _AssignImageSpriteImpl_d__4 : ValueType
		{
			// Token: 0x06010584 RID: 66948 RVA: 0x003CCB28 File Offset: 0x003CAD28
			// Note: this type is marked as 'beforefieldinit'.
			static _AssignImageSpriteImpl_d__4()
			{
				Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, "<AssignImageSpriteImpl>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr);
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, "<>1__state");
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, "<>t__builder");
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_imageComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, "imageComponent");
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_spriteHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, "spriteHandle");
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, "<>8__1");
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, "cancellationToken");
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_postProcessCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, "postProcessCallback");
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, "<>u__1");
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, 100684695);
				DescriberHelper._AssignImageSpriteImpl_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr, 100684696);
			}

			// Token: 0x06010585 RID: 66949 RVA: 0x003CCC1C File Offset: 0x003CAE1C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 263134, RefRangeEnd = 263136, XrefRangeStart = 263084, XrefRangeEnd = 263134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper._AssignImageSpriteImpl_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010586 RID: 66950 RVA: 0x003CCC54 File Offset: 0x003CAE54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper._AssignImageSpriteImpl_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010587 RID: 66951 RVA: 0x0008E98B File Offset: 0x0008CB8B
			public _AssignImageSpriteImpl_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010588 RID: 66952 RVA: 0x0008E994 File Offset: 0x0008CB94
			public _AssignImageSpriteImpl_d__4() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriberHelper._AssignImageSpriteImpl_d__4>.NativeClassPtr))
			{
			}

			// Token: 0x17005570 RID: 21872
			// (get) Token: 0x06010589 RID: 66953 RVA: 0x003CCC9C File Offset: 0x003CAE9C
			// (set) Token: 0x0601058A RID: 66954 RVA: 0x0008E9A6 File Offset: 0x0008CBA6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005571 RID: 21873
			// (get) Token: 0x0601058B RID: 66955 RVA: 0x003CCCC4 File Offset: 0x003CAEC4
			// (set) Token: 0x0601058C RID: 66956 RVA: 0x0008E9C1 File Offset: 0x0008CBC1
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005572 RID: 21874
			// (get) Token: 0x0601058D RID: 66957 RVA: 0x003CCCF4 File Offset: 0x003CAEF4
			// (set) Token: 0x0601058E RID: 66958 RVA: 0x0008E9EF File Offset: 0x0008CBEF
			public unsafe Image imageComponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_imageComponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_imageComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005573 RID: 21875
			// (get) Token: 0x0601058F RID: 66959 RVA: 0x003CCD24 File Offset: 0x003CAF24
			// (set) Token: 0x06010590 RID: 66960 RVA: 0x0008EA0E File Offset: 0x0008CC0E
			public UniTask<IAssetHandle<Sprite>> spriteHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_spriteHandle);
					return new UniTask<IAssetHandle<Sprite>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_spriteHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005574 RID: 21876
			// (get) Token: 0x06010591 RID: 66961 RVA: 0x003CCD54 File Offset: 0x003CAF54
			// (set) Token: 0x06010592 RID: 66962 RVA: 0x0008EA3C File Offset: 0x0008CC3C
			public unsafe DescriberHelper.__c__DisplayClass4_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescriberHelper.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005575 RID: 21877
			// (get) Token: 0x06010593 RID: 66963 RVA: 0x003CCD84 File Offset: 0x003CAF84
			// (set) Token: 0x06010594 RID: 66964 RVA: 0x0008EA5B File Offset: 0x0008CC5B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005576 RID: 21878
			// (get) Token: 0x06010595 RID: 66965 RVA: 0x003CCDB4 File Offset: 0x003CAFB4
			// (set) Token: 0x06010596 RID: 66966 RVA: 0x0008EA89 File Offset: 0x0008CC89
			public unsafe Action<Image> postProcessCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_postProcessCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr_postProcessCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005577 RID: 21879
			// (get) Token: 0x06010597 RID: 66967 RVA: 0x003CCDE4 File Offset: 0x003CAFE4
			// (set) Token: 0x06010598 RID: 66968 RVA: 0x0008EAA8 File Offset: 0x0008CCA8
			public UniTask<IAssetHandle<Sprite>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<Sprite>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper._AssignImageSpriteImpl_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A5A6 RID: 42406
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A5A7 RID: 42407
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A5A8 RID: 42408
			private static readonly IntPtr NativeFieldInfoPtr_imageComponent;

			// Token: 0x0400A5A9 RID: 42409
			private static readonly IntPtr NativeFieldInfoPtr_spriteHandle;

			// Token: 0x0400A5AA RID: 42410
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400A5AB RID: 42411
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400A5AC RID: 42412
			private static readonly IntPtr NativeFieldInfoPtr_postProcessCallback;

			// Token: 0x0400A5AD RID: 42413
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A5AE RID: 42414
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A5AF RID: 42415
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E4B RID: 3659
		[ObfuscatedName("Common.UI.DescriberHelper+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x06010599 RID: 66969 RVA: 0x003CCE14 File Offset: 0x003CB014
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriberHelper>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass5_0>.NativeClassPtr);
				DescriberHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass5_0>.NativeClassPtr, "multiplier");
				DescriberHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass5_0>.NativeClassPtr, 100684697);
				DescriberHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__GetMultiplyImageSizePostProcessor_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass5_0>.NativeClassPtr, 100684698);
			}

			// Token: 0x0601059A RID: 66970 RVA: 0x003CCE7C File Offset: 0x003CB07C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescriberHelper.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601059B RID: 66971 RVA: 0x003CCEB8 File Offset: 0x003CB0B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263136, XrefRangeEnd = 263140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetMultiplyImageSizePostProcessor_b__0(Image source)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescriberHelper.__c__DisplayClass5_0.NativeMethodInfoPtr__GetMultiplyImageSizePostProcessor_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601059C RID: 66972 RVA: 0x0008EAD6 File Offset: 0x0008CCD6
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005578 RID: 21880
			// (get) Token: 0x0601059D RID: 66973 RVA: 0x003CCEFC File Offset: 0x003CB0FC
			// (set) Token: 0x0601059E RID: 66974 RVA: 0x0008EADF File Offset: 0x0008CCDF
			public unsafe int multiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_multiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescriberHelper.__c__DisplayClass5_0.NativeFieldInfoPtr_multiplier)) = value;
				}
			}

			// Token: 0x0400A5B0 RID: 42416
			private static readonly IntPtr NativeFieldInfoPtr_multiplier;

			// Token: 0x0400A5B1 RID: 42417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5B2 RID: 42418
			private static readonly IntPtr NativeMethodInfoPtr__GetMultiplyImageSizePostProcessor_b__0_Internal_Void_Image_0;
		}
	}
}
