using System;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000363 RID: 867
	public class NormalGuestDescriber : LanguageBaseDescriber
	{
		// Token: 0x06006628 RID: 26152 RVA: 0x001F3B5C File Offset: 0x001F1D5C
		// Note: this type is marked as 'beforefieldinit'.
		static NormalGuestDescriber()
		{
			Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "NormalGuestDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr);
			NormalGuestDescriber.NativeFieldInfoPtr_bse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "bse");
			NormalGuestDescriber.NativeFieldInfoPtr_eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "eyes");
			NormalGuestDescriber.NativeFieldInfoPtr_trimBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "trimBack");
			NormalGuestDescriber.NativeFieldInfoPtr_trimFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "trimFront");
			NormalGuestDescriber.NativeFieldInfoPtr_foodTagParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "foodTagParent");
			NormalGuestDescriber.NativeFieldInfoPtr_bevTagParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "bevTagParent");
			NormalGuestDescriber.NativeFieldInfoPtr_foodTagField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "foodTagField");
			NormalGuestDescriber.NativeFieldInfoPtr_bevTagField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "bevTagField");
			NormalGuestDescriber.NativeFieldInfoPtr_placeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "placeText");
			NormalGuestDescriber.NativeFieldInfoPtr_OnCancelDescribeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "OnCancelDescribeCallback");
			NormalGuestDescriber.NativeFieldInfoPtr_allBevTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "allBevTagInstances");
			NormalGuestDescriber.NativeFieldInfoPtr_allFoodTagInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "allFoodTagInstances");
			NormalGuestDescriber.NativeFieldInfoPtr_allPlacesInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "allPlacesInstances");
			NormalGuestDescriber.NativeFieldInfoPtr_trimBackCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "trimBackCoroutine");
			NormalGuestDescriber.NativeFieldInfoPtr_trimFrontCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "trimFrontCoroutine");
			NormalGuestDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, 100684699);
			NormalGuestDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, 100684700);
			NormalGuestDescriber.NativeMethodInfoPtr_StartTrimCoroutine_Private_Void_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, 100684701);
			NormalGuestDescriber.NativeMethodInfoPtr_Describe_Public_Void_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, 100684702);
			NormalGuestDescriber.NativeMethodInfoPtr_PrintFrequentlyShownText_Public_Static_Void_PlaceRenderMode_Boolean_IEnumerable_1_Int32_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, 100684703);
			NormalGuestDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, 100684704);
			NormalGuestDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, 100684705);
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x001F3D44 File Offset: 0x001F1F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263265, XrefRangeEnd = 263270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPreload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestDescriber.NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x001F3D80 File Offset: 0x001F1F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263270, XrefRangeEnd = 263275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDescriberDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestDescriber.NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x001F3DBC File Offset: 0x001F1FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263295, RefRangeEnd = 263296, XrefRangeStart = 263275, XrefRangeEnd = 263295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTrimCoroutine(CharacterSpriteSetCompact pixel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pixel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.NativeMethodInfoPtr_StartTrimCoroutine_Private_Void_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x001F3E00 File Offset: 0x001F2000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263358, RefRangeEnd = 263359, XrefRangeStart = 263296, XrefRangeEnd = 263358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(NormalGuest detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.NativeMethodInfoPtr_Describe_Public_Void_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x001F3E44 File Offset: 0x001F2044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263421, RefRangeEnd = 263423, XrefRangeStart = 263359, XrefRangeEnd = 263421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrintFrequentlyShownText(NormalGuestDescriber.PlaceRenderMode mode, bool known, IEnumerable<int> shownIzakayaIds, TextMeshProUGUI text)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref known;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shownIzakayaIds);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.NativeMethodInfoPtr_PrintFrequentlyShownText_Public_Static_Void_PlaceRenderMode_Boolean_IEnumerable_1_Int32_TextMeshProUGUI_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x001F3EA8 File Offset: 0x001F20A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263423, XrefRangeEnd = 263439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuestDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x001F3EE4 File Offset: 0x001F20E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263439, XrefRangeEnd = 263458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NormalGuestDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x00037291 File Offset: 0x00035491
		public NormalGuestDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x06006631 RID: 26161 RVA: 0x001F3F20 File Offset: 0x001F2120
		// (set) Token: 0x06006632 RID: 26162 RVA: 0x0003729A File Offset: 0x0003549A
		public unsafe Image bse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_bse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_bse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x06006633 RID: 26163 RVA: 0x001F3F50 File Offset: 0x001F2150
		// (set) Token: 0x06006634 RID: 26164 RVA: 0x000372B9 File Offset: 0x000354B9
		public unsafe Image eyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_eyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x06006635 RID: 26165 RVA: 0x001F3F80 File Offset: 0x001F2180
		// (set) Token: 0x06006636 RID: 26166 RVA: 0x000372D8 File Offset: 0x000354D8
		public unsafe Image trimBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_trimBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_trimBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x06006637 RID: 26167 RVA: 0x001F3FB0 File Offset: 0x001F21B0
		// (set) Token: 0x06006638 RID: 26168 RVA: 0x000372F7 File Offset: 0x000354F7
		public unsafe Image trimFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_trimFront);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_trimFront), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x06006639 RID: 26169 RVA: 0x001F3FE0 File Offset: 0x001F21E0
		// (set) Token: 0x0600663A RID: 26170 RVA: 0x00037316 File Offset: 0x00035516
		public unsafe GameObject foodTagParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_foodTagParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_foodTagParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x0600663B RID: 26171 RVA: 0x001F4010 File Offset: 0x001F2210
		// (set) Token: 0x0600663C RID: 26172 RVA: 0x00037335 File Offset: 0x00035535
		public unsafe GameObject bevTagParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_bevTagParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_bevTagParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x0600663D RID: 26173 RVA: 0x001F4040 File Offset: 0x001F2240
		// (set) Token: 0x0600663E RID: 26174 RVA: 0x00037354 File Offset: 0x00035554
		public unsafe RectTransform foodTagField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_foodTagField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_foodTagField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x0600663F RID: 26175 RVA: 0x001F4070 File Offset: 0x001F2270
		// (set) Token: 0x06006640 RID: 26176 RVA: 0x00037373 File Offset: 0x00035573
		public unsafe RectTransform bevTagField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_bevTagField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_bevTagField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x06006641 RID: 26177 RVA: 0x001F40A0 File Offset: 0x001F22A0
		// (set) Token: 0x06006642 RID: 26178 RVA: 0x00037392 File Offset: 0x00035592
		public unsafe TextMeshProUGUI placeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_placeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_placeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x06006643 RID: 26179 RVA: 0x001F40D0 File Offset: 0x001F22D0
		// (set) Token: 0x06006644 RID: 26180 RVA: 0x000373B1 File Offset: 0x000355B1
		public unsafe Action OnCancelDescribeCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_OnCancelDescribeCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_OnCancelDescribeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x06006645 RID: 26181 RVA: 0x001F4100 File Offset: 0x001F2300
		// (set) Token: 0x06006646 RID: 26182 RVA: 0x000373D0 File Offset: 0x000355D0
		public unsafe List<GameObject> allBevTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_allBevTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_allBevTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x06006647 RID: 26183 RVA: 0x001F4130 File Offset: 0x001F2330
		// (set) Token: 0x06006648 RID: 26184 RVA: 0x000373EF File Offset: 0x000355EF
		public unsafe List<GameObject> allFoodTagInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_allFoodTagInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_allFoodTagInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x06006649 RID: 26185 RVA: 0x001F4160 File Offset: 0x001F2360
		// (set) Token: 0x0600664A RID: 26186 RVA: 0x0003740E File Offset: 0x0003560E
		public unsafe List<GameObject> allPlacesInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_allPlacesInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_allPlacesInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x0600664B RID: 26187 RVA: 0x001F4190 File Offset: 0x001F2390
		// (set) Token: 0x0600664C RID: 26188 RVA: 0x0003742D File Offset: 0x0003562D
		public unsafe Coroutine trimBackCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_trimBackCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_trimBackCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x0600664D RID: 26189 RVA: 0x001F41C0 File Offset: 0x001F23C0
		// (set) Token: 0x0600664E RID: 26190 RVA: 0x0003744C File Offset: 0x0003564C
		public unsafe Coroutine trimFrontCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_trimFrontCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.NativeFieldInfoPtr_trimFrontCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043C4 RID: 17348
		private static readonly IntPtr NativeFieldInfoPtr_bse;

		// Token: 0x040043C5 RID: 17349
		private static readonly IntPtr NativeFieldInfoPtr_eyes;

		// Token: 0x040043C6 RID: 17350
		private static readonly IntPtr NativeFieldInfoPtr_trimBack;

		// Token: 0x040043C7 RID: 17351
		private static readonly IntPtr NativeFieldInfoPtr_trimFront;

		// Token: 0x040043C8 RID: 17352
		private static readonly IntPtr NativeFieldInfoPtr_foodTagParent;

		// Token: 0x040043C9 RID: 17353
		private static readonly IntPtr NativeFieldInfoPtr_bevTagParent;

		// Token: 0x040043CA RID: 17354
		private static readonly IntPtr NativeFieldInfoPtr_foodTagField;

		// Token: 0x040043CB RID: 17355
		private static readonly IntPtr NativeFieldInfoPtr_bevTagField;

		// Token: 0x040043CC RID: 17356
		private static readonly IntPtr NativeFieldInfoPtr_placeText;

		// Token: 0x040043CD RID: 17357
		private static readonly IntPtr NativeFieldInfoPtr_OnCancelDescribeCallback;

		// Token: 0x040043CE RID: 17358
		private static readonly IntPtr NativeFieldInfoPtr_allBevTagInstances;

		// Token: 0x040043CF RID: 17359
		private static readonly IntPtr NativeFieldInfoPtr_allFoodTagInstances;

		// Token: 0x040043D0 RID: 17360
		private static readonly IntPtr NativeFieldInfoPtr_allPlacesInstances;

		// Token: 0x040043D1 RID: 17361
		private static readonly IntPtr NativeFieldInfoPtr_trimBackCoroutine;

		// Token: 0x040043D2 RID: 17362
		private static readonly IntPtr NativeFieldInfoPtr_trimFrontCoroutine;

		// Token: 0x040043D3 RID: 17363
		private static readonly IntPtr NativeMethodInfoPtr_OnPreload_Protected_Virtual_Void_0;

		// Token: 0x040043D4 RID: 17364
		private static readonly IntPtr NativeMethodInfoPtr_OnDescriberDestroyed_Protected_Virtual_Void_0;

		// Token: 0x040043D5 RID: 17365
		private static readonly IntPtr NativeMethodInfoPtr_StartTrimCoroutine_Private_Void_CharacterSpriteSetCompact_0;

		// Token: 0x040043D6 RID: 17366
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_NormalGuest_0;

		// Token: 0x040043D7 RID: 17367
		private static readonly IntPtr NativeMethodInfoPtr_PrintFrequentlyShownText_Public_Static_Void_PlaceRenderMode_Boolean_IEnumerable_1_Int32_TextMeshProUGUI_0;

		// Token: 0x040043D8 RID: 17368
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040043D9 RID: 17369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E4C RID: 3660
		public enum PlaceRenderMode
		{
			// Token: 0x0400A5B4 RID: 42420
			IncludeOnlyProvidedPlaces,
			// Token: 0x0400A5B5 RID: 42421
			ExcludeProvidedPlaces
		}

		// Token: 0x02000E4D RID: 3661
		[ObfuscatedName("Common.UI.NormalGuestDescriber+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0601059F RID: 66975 RVA: 0x003CCF24 File Offset: 0x003CB124
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0>.NativeClassPtr);
				NormalGuestDescriber.__c__DisplayClass17_0.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0>.NativeClassPtr, "pixel");
				NormalGuestDescriber.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				NormalGuestDescriber.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0>.NativeClassPtr, 100684706);
				NormalGuestDescriber.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0>.NativeClassPtr, 100684707);
			}

			// Token: 0x060105A0 RID: 66976 RVA: 0x003CCFA0 File Offset: 0x003CB1A0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060105A1 RID: 66977 RVA: 0x003CCFDC File Offset: 0x003CB1DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 263248, RefRangeEnd = 263250, XrefRangeStart = 263243, XrefRangeEnd = 263248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Single_Int32_Boolean_0(float delay, int arraySize, bool frontOrBack)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref delay;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frontOrBack;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Single_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060105A2 RID: 66978 RVA: 0x0008EAFA File Offset: 0x0008CCFA
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005579 RID: 21881
			// (get) Token: 0x060105A3 RID: 66979 RVA: 0x003CD044 File Offset: 0x003CB244
			// (set) Token: 0x060105A4 RID: 66980 RVA: 0x0008EB03 File Offset: 0x0008CD03
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700557A RID: 21882
			// (get) Token: 0x060105A5 RID: 66981 RVA: 0x003CD074 File Offset: 0x003CB274
			// (set) Token: 0x060105A6 RID: 66982 RVA: 0x0008EB22 File Offset: 0x0008CD22
			public unsafe NormalGuestDescriber __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuestDescriber>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5B6 RID: 42422
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x0400A5B7 RID: 42423
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5B8 RID: 42424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5B9 RID: 42425
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Single_Int32_Boolean_0;

			// Token: 0x020010B3 RID: 4275
			[ObfuscatedName("Common.UI.NormalGuestDescriber+<>c__DisplayClass17_0+<<StartTrimCoroutine>g__Display|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique : Il2CppSystem.Object
			{
				// Token: 0x060122C7 RID: 74439 RVA: 0x0042513C File Offset: 0x0042333C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique()
				{
					Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0>.NativeClassPtr, "<<StartTrimCoroutine>g__Display|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr);
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<>1__state");
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<>2__current");
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "delay");
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_frontOrBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "frontOrBack");
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<>4__this");
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_arraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "arraySize");
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<index>5__2");
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__wait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, "<wait>5__3");
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684708);
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684709);
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684710);
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684711);
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684712);
					NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr, 100684713);
				}

				// Token: 0x060122C8 RID: 74440 RVA: 0x00425280 File Offset: 0x00423480
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122C9 RID: 74441 RVA: 0x004252C8 File Offset: 0x004234C8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122CA RID: 74442 RVA: 0x004252FC File Offset: 0x004234FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263226, XrefRangeEnd = 263237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005F12 RID: 24338
				// (get) Token: 0x060122CB RID: 74443 RVA: 0x00425338 File Offset: 0x00423538
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060122CC RID: 74444 RVA: 0x00425378 File Offset: 0x00423578
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263237, XrefRangeEnd = 263243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005F13 RID: 24339
				// (get) Token: 0x060122CD RID: 74445 RVA: 0x004253AC File Offset: 0x004235AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060122CE RID: 74446 RVA: 0x0009DC9E File Offset: 0x0009BE9E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F0A RID: 24330
				// (get) Token: 0x060122CF RID: 74447 RVA: 0x004253EC File Offset: 0x004235EC
				// (set) Token: 0x060122D0 RID: 74448 RVA: 0x0009DCA7 File Offset: 0x0009BEA7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005F0B RID: 24331
				// (get) Token: 0x060122D1 RID: 74449 RVA: 0x00425414 File Offset: 0x00423614
				// (set) Token: 0x060122D2 RID: 74450 RVA: 0x0009DCC2 File Offset: 0x0009BEC2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F0C RID: 24332
				// (get) Token: 0x060122D3 RID: 74451 RVA: 0x00425444 File Offset: 0x00423644
				// (set) Token: 0x060122D4 RID: 74452 RVA: 0x0009DCE1 File Offset: 0x0009BEE1
				public unsafe float delay
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_delay);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_delay)) = value;
					}
				}

				// Token: 0x17005F0D RID: 24333
				// (get) Token: 0x060122D5 RID: 74453 RVA: 0x0042546C File Offset: 0x0042366C
				// (set) Token: 0x060122D6 RID: 74454 RVA: 0x0009DCFC File Offset: 0x0009BEFC
				public unsafe bool frontOrBack
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_frontOrBack);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_frontOrBack)) = value;
					}
				}

				// Token: 0x17005F0E RID: 24334
				// (get) Token: 0x060122D7 RID: 74455 RVA: 0x00425494 File Offset: 0x00423694
				// (set) Token: 0x060122D8 RID: 74456 RVA: 0x0009DD17 File Offset: 0x0009BF17
				public unsafe NormalGuestDescriber.__c__DisplayClass17_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuestDescriber.__c__DisplayClass17_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F0F RID: 24335
				// (get) Token: 0x060122D9 RID: 74457 RVA: 0x004254C4 File Offset: 0x004236C4
				// (set) Token: 0x060122DA RID: 74458 RVA: 0x0009DD36 File Offset: 0x0009BF36
				public unsafe int arraySize
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_arraySize);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr_arraySize)) = value;
					}
				}

				// Token: 0x17005F10 RID: 24336
				// (get) Token: 0x060122DB RID: 74459 RVA: 0x004254EC File Offset: 0x004236EC
				// (set) Token: 0x060122DC RID: 74460 RVA: 0x0009DD51 File Offset: 0x0009BF51
				public unsafe int _index_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__index_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__index_5__2)) = value;
					}
				}

				// Token: 0x17005F11 RID: 24337
				// (get) Token: 0x060122DD RID: 74461 RVA: 0x00425514 File Offset: 0x00423714
				// (set) Token: 0x060122DE RID: 74462 RVA: 0x0009DD6C File Offset: 0x0009BF6C
				public unsafe WaitForSecondsRealtime _wait_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__wait_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideBofrarInWaObUnique.NativeFieldInfoPtr__wait_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B839 RID: 47161
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B83A RID: 47162
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B83B RID: 47163
				private static readonly IntPtr NativeFieldInfoPtr_delay;

				// Token: 0x0400B83C RID: 47164
				private static readonly IntPtr NativeFieldInfoPtr_frontOrBack;

				// Token: 0x0400B83D RID: 47165
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B83E RID: 47166
				private static readonly IntPtr NativeFieldInfoPtr_arraySize;

				// Token: 0x0400B83F RID: 47167
				private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

				// Token: 0x0400B840 RID: 47168
				private static readonly IntPtr NativeFieldInfoPtr__wait_5__3;

				// Token: 0x0400B841 RID: 47169
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B842 RID: 47170
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B843 RID: 47171
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B844 RID: 47172
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B845 RID: 47173
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B846 RID: 47174
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000E4E RID: 3662
		[ObfuscatedName("Common.UI.NormalGuestDescriber+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x060105A7 RID: 66983 RVA: 0x003CD0A4 File Offset: 0x003CB2A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass18_0>.NativeClassPtr);
				NormalGuestDescriber.__c__DisplayClass18_0.NativeFieldInfoPtr_detail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass18_0>.NativeClassPtr, "detail");
				NormalGuestDescriber.__c__DisplayClass18_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass18_0>.NativeClassPtr, "<>9__2");
				NormalGuestDescriber.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass18_0>.NativeClassPtr, 100684714);
				NormalGuestDescriber.__c__DisplayClass18_0.NativeMethodInfoPtr__Describe_b__0_Internal_Boolean_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass18_0>.NativeClassPtr, 100684715);
				NormalGuestDescriber.__c__DisplayClass18_0.NativeMethodInfoPtr__Describe_b__2_Internal_Boolean_NormalGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass18_0>.NativeClassPtr, 100684716);
			}

			// Token: 0x060105A8 RID: 66984 RVA: 0x003CD134 File Offset: 0x003CB334
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestDescriber.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060105A9 RID: 66985 RVA: 0x003CD170 File Offset: 0x003CB370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263250, XrefRangeEnd = 263261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Describe_b__0(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass18_0.NativeMethodInfoPtr__Describe_b__0_Internal_Boolean_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105AA RID: 66986 RVA: 0x003CD1C0 File Offset: 0x003CB3C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263261, XrefRangeEnd = 263265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Describe_b__2(Izakaya.NormalGuestGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c__DisplayClass18_0.NativeMethodInfoPtr__Describe_b__2_Internal_Boolean_NormalGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105AB RID: 66987 RVA: 0x0008EB41 File Offset: 0x0008CD41
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700557B RID: 21883
			// (get) Token: 0x060105AC RID: 66988 RVA: 0x003CD210 File Offset: 0x003CB410
			// (set) Token: 0x060105AD RID: 66989 RVA: 0x0008EB4A File Offset: 0x0008CD4A
			public unsafe NormalGuest detail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass18_0.NativeFieldInfoPtr_detail);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass18_0.NativeFieldInfoPtr_detail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700557C RID: 21884
			// (get) Token: 0x060105AE RID: 66990 RVA: 0x003CD240 File Offset: 0x003CB440
			// (set) Token: 0x060105AF RID: 66991 RVA: 0x0008EB69 File Offset: 0x0008CD69
			public unsafe Func<Izakaya.NormalGuestGroup, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass18_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.NormalGuestGroup, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestDescriber.__c__DisplayClass18_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5BA RID: 42426
			private static readonly IntPtr NativeFieldInfoPtr_detail;

			// Token: 0x0400A5BB RID: 42427
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400A5BC RID: 42428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5BD RID: 42429
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__0_Internal_Boolean_Izakaya_0;

			// Token: 0x0400A5BE RID: 42430
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__2_Internal_Boolean_NormalGuestGroup_0;
		}

		// Token: 0x02000E4F RID: 3663
		[ObfuscatedName("Common.UI.NormalGuestDescriber+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060105B0 RID: 66992 RVA: 0x003CD270 File Offset: 0x003CB470
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NormalGuestDescriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuestDescriber>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestDescriber.__c>.NativeClassPtr);
				NormalGuestDescriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c>.NativeClassPtr, "<>9");
				NormalGuestDescriber.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestDescriber.__c>.NativeClassPtr, "<>9__18_1");
				NormalGuestDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c>.NativeClassPtr, 100684718);
				NormalGuestDescriber.__c.NativeMethodInfoPtr__Describe_b__18_1_Internal_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestDescriber.__c>.NativeClassPtr, 100684719);
			}

			// Token: 0x060105B1 RID: 66993 RVA: 0x003CD2EC File Offset: 0x003CB4EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestDescriber.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060105B2 RID: 66994 RVA: 0x003CD328 File Offset: 0x003CB528
			[CallerCount(0)]
			public unsafe int _Describe_b__18_1(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestDescriber.__c.NativeMethodInfoPtr__Describe_b__18_1_Internal_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105B3 RID: 66995 RVA: 0x0008EB88 File Offset: 0x0008CD88
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700557D RID: 21885
			// (get) Token: 0x060105B4 RID: 66996 RVA: 0x003CD378 File Offset: 0x003CB578
			// (set) Token: 0x060105B5 RID: 66997 RVA: 0x0008EB91 File Offset: 0x0008CD91
			public unsafe static NormalGuestDescriber.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestDescriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuestDescriber.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestDescriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700557E RID: 21886
			// (get) Token: 0x060105B6 RID: 66998 RVA: 0x003CD3A0 File Offset: 0x003CB5A0
			// (set) Token: 0x060105B7 RID: 66999 RVA: 0x0008EBA3 File Offset: 0x0008CDA3
			public unsafe static Func<Izakaya, int> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuestDescriber.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuestDescriber.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5BF RID: 42431
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A5C0 RID: 42432
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x0400A5C1 RID: 42433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5C2 RID: 42434
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__18_1_Internal_Int32_Izakaya_0;
		}
	}
}
