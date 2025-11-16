using System;
using GameData.Core.Collections.CharacterUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200024B RID: 587
	[Serializable]
	public class NormalGuest : GuestBase
	{
		// Token: 0x06004979 RID: 18809 RVA: 0x0019DA64 File Offset: 0x0019BC64
		// Note: this type is marked as 'beforefieldinit'.
		static NormalGuest()
		{
			Il2CppClassPointerStore<NormalGuest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "NormalGuest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr);
			NormalGuest.NativeFieldInfoPtr_convGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "convGroup");
			NormalGuest.NativeFieldInfoPtr_fundMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "fundMultiplier");
			NormalGuest.NativeFieldInfoPtr_likeFoodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "likeFoodTag");
			NormalGuest.NativeFieldInfoPtr_likeBevTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "likeBevTag");
			NormalGuest.NativeFieldInfoPtr_evaluation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "evaluation");
			NormalGuest.NativeFieldInfoPtr_isLikeAllFoodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "isLikeAllFoodTag");
			NormalGuest.NativeFieldInfoPtr_isLikeAllBevTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "isLikeAllBevTag");
			NormalGuest.NativeFieldInfoPtr_isChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "isChild");
			NormalGuest.NativeFieldInfoPtr_doNotShowInNotebook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "doNotShowInNotebook");
			NormalGuest.NativeFieldInfoPtr_m_GuestFoodEasterEggData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "m_GuestFoodEasterEggData");
			NormalGuest.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Boolean_Boolean_Boolean_Boolean_GuestFoodEasterEggData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677933);
			NormalGuest.NativeMethodInfoPtr_get_CharacterPixel_Public_Virtual_get_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677934);
			NormalGuest.NativeMethodInfoPtr_get_Text_Public_Virtual_get_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677935);
			NormalGuest.NativeMethodInfoPtr_get_LikeFoodTag_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677936);
			NormalGuest.NativeMethodInfoPtr_get_LikeBevTag_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677937);
			NormalGuest.NativeMethodInfoPtr_get_Evaluation_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677938);
			NormalGuest.NativeMethodInfoPtr_get_FundMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677939);
			NormalGuest.NativeMethodInfoPtr_get_ConvGroupValue_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677940);
			NormalGuest.NativeMethodInfoPtr_get_EvaluationValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677941);
			NormalGuest.NativeMethodInfoPtr_get_IsChild_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677942);
			NormalGuest.NativeMethodInfoPtr_get_IsLikeAllFoodTag_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677943);
			NormalGuest.NativeMethodInfoPtr_get_IsLikeAllBevTag_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677944);
			NormalGuest.NativeMethodInfoPtr_get_DoNotShowInNotebook_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677945);
			NormalGuest.NativeMethodInfoPtr_get_GuestFoodEasterEggData_Public_get_GuestFoodEasterEggData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677946);
			NormalGuest.NativeMethodInfoPtr_GetFundRange_Public_Virtual_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677947);
			NormalGuest.NativeMethodInfoPtr_OnGetVisual_Protected_Virtual_GuestProfilePair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677948);
			NormalGuest.NativeMethodInfoPtr_GenerateRandomConvMessage_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677949);
			NormalGuest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677950);
			NormalGuest.NativeMethodInfoPtr__GetFundRange_b__37_0_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, 100677951);
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x0019DCD8 File Offset: 0x0019BED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191647, XrefRangeEnd = 191657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NormalGuest(int id, float fundMultiplier, int evaluation, Il2CppStructArray<int> likeFoodTag, Il2CppStructArray<int> likeBevTag, Il2CppStructArray<int> convGroup, bool isLikeAllFoodTag, bool isLikeAllBevTag, bool isChild, bool doNotShowInNotebook, GuestFoodEasterEggData guestFoodEasterEggData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fundMultiplier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evaluation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(likeFoodTag);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(likeBevTag);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(convGroup);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLikeAllFoodTag;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLikeAllBevTag;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isChild;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotShowInNotebook;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestFoodEasterEggData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Boolean_Boolean_Boolean_Boolean_GuestFoodEasterEggData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x0600497B RID: 18811 RVA: 0x0019DDC4 File Offset: 0x0019BFC4
		public unsafe override CharacterSpriteSetCompact CharacterPixel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191657, XrefRangeEnd = 191661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuest.NativeMethodInfoPtr_get_CharacterPixel_Public_Virtual_get_CharacterSpriteSetCompact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x0600497C RID: 18812 RVA: 0x0019DE10 File Offset: 0x0019C010
		public unsafe override LanguageBase Text
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191661, XrefRangeEnd = 191662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuest.NativeMethodInfoPtr_get_Text_Public_Virtual_get_LanguageBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x0600497D RID: 18813 RVA: 0x0019DE5C File Offset: 0x0019C05C
		public unsafe override Il2CppStructArray<int> LikeFoodTag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191662, XrefRangeEnd = 191669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuest.NativeMethodInfoPtr_get_LikeFoodTag_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x0600497E RID: 18814 RVA: 0x0019DEA8 File Offset: 0x0019C0A8
		public unsafe Il2CppStructArray<int> LikeBevTag
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 191694, RefRangeEnd = 191699, XrefRangeStart = 191669, XrefRangeEnd = 191694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_LikeBevTag_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x0019DEE8 File Offset: 0x0019C0E8
		public unsafe Il2CppStringArray Evaluation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 191705, RefRangeEnd = 191706, XrefRangeStart = 191699, XrefRangeEnd = 191705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_Evaluation_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06004980 RID: 18816 RVA: 0x0019DF28 File Offset: 0x0019C128
		public unsafe float FundMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_FundMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x0019DF64 File Offset: 0x0019C164
		public unsafe Il2CppStructArray<int> ConvGroupValue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_ConvGroupValue_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06004982 RID: 18818 RVA: 0x0019DFA4 File Offset: 0x0019C1A4
		public unsafe int EvaluationValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_EvaluationValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06004983 RID: 18819 RVA: 0x0019DFE0 File Offset: 0x0019C1E0
		public unsafe bool IsChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_IsChild_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06004984 RID: 18820 RVA: 0x0019E01C File Offset: 0x0019C21C
		public unsafe bool IsLikeAllFoodTag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_IsLikeAllFoodTag_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06004985 RID: 18821 RVA: 0x0019E058 File Offset: 0x0019C258
		public unsafe bool IsLikeAllBevTag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_IsLikeAllBevTag_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06004986 RID: 18822 RVA: 0x0019E094 File Offset: 0x0019C294
		public unsafe bool DoNotShowInNotebook
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_DoNotShowInNotebook_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06004987 RID: 18823 RVA: 0x0019E0D0 File Offset: 0x0019C2D0
		public unsafe GuestFoodEasterEggData GuestFoodEasterEggData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_get_GuestFoodEasterEggData_Public_get_GuestFoodEasterEggData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestFoodEasterEggData>(intPtr3) : null;
			}
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x0019E110 File Offset: 0x0019C310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191706, XrefRangeEnd = 191717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2Int GetFundRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuest.NativeMethodInfoPtr_GetFundRange_Public_Virtual_Vector2Int_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x0019E158 File Offset: 0x0019C358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191717, XrefRangeEnd = 191721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GuestProfilePair OnGetVisual(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuest.NativeMethodInfoPtr_OnGetVisual_Protected_Virtual_GuestProfilePair_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr3) : null;
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x0019E1B0 File Offset: 0x0019C3B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191725, RefRangeEnd = 191726, XrefRangeStart = 191721, XrefRangeEnd = 191725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateRandomConvMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr_GenerateRandomConvMessage_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x0019E1E8 File Offset: 0x0019C3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191726, XrefRangeEnd = 191824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalGuest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x0019E22C File Offset: 0x0019C42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191824, XrefRangeEnd = 191825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _GetFundRange_b__37_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.NativeMethodInfoPtr__GetFundRange_b__37_0_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00025B3F File Offset: 0x00023D3F
		public NormalGuest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x0600498E RID: 18830 RVA: 0x0019E278 File Offset: 0x0019C478
		// (set) Token: 0x0600498F RID: 18831 RVA: 0x00025B48 File Offset: 0x00023D48
		public unsafe Il2CppStructArray<int> convGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_convGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_convGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x0019E2A8 File Offset: 0x0019C4A8
		// (set) Token: 0x06004991 RID: 18833 RVA: 0x00025B67 File Offset: 0x00023D67
		public unsafe float fundMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_fundMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_fundMultiplier)) = value;
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x0019E2D0 File Offset: 0x0019C4D0
		// (set) Token: 0x06004993 RID: 18835 RVA: 0x00025B82 File Offset: 0x00023D82
		public unsafe Il2CppStructArray<int> likeFoodTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_likeFoodTag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_likeFoodTag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06004994 RID: 18836 RVA: 0x0019E300 File Offset: 0x0019C500
		// (set) Token: 0x06004995 RID: 18837 RVA: 0x00025BA1 File Offset: 0x00023DA1
		public unsafe Il2CppStructArray<int> likeBevTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_likeBevTag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_likeBevTag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x06004996 RID: 18838 RVA: 0x0019E330 File Offset: 0x0019C530
		// (set) Token: 0x06004997 RID: 18839 RVA: 0x00025BC0 File Offset: 0x00023DC0
		public unsafe int evaluation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_evaluation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_evaluation)) = value;
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06004998 RID: 18840 RVA: 0x0019E358 File Offset: 0x0019C558
		// (set) Token: 0x06004999 RID: 18841 RVA: 0x00025BDB File Offset: 0x00023DDB
		public unsafe bool isLikeAllFoodTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_isLikeAllFoodTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_isLikeAllFoodTag)) = value;
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x0600499A RID: 18842 RVA: 0x0019E380 File Offset: 0x0019C580
		// (set) Token: 0x0600499B RID: 18843 RVA: 0x00025BF6 File Offset: 0x00023DF6
		public unsafe bool isLikeAllBevTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_isLikeAllBevTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_isLikeAllBevTag)) = value;
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x0600499C RID: 18844 RVA: 0x0019E3A8 File Offset: 0x0019C5A8
		// (set) Token: 0x0600499D RID: 18845 RVA: 0x00025C11 File Offset: 0x00023E11
		public unsafe bool isChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_isChild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_isChild)) = value;
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x0600499E RID: 18846 RVA: 0x0019E3D0 File Offset: 0x0019C5D0
		// (set) Token: 0x0600499F RID: 18847 RVA: 0x00025C2C File Offset: 0x00023E2C
		public unsafe bool doNotShowInNotebook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_doNotShowInNotebook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_doNotShowInNotebook)) = value;
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x060049A0 RID: 18848 RVA: 0x0019E3F8 File Offset: 0x0019C5F8
		// (set) Token: 0x060049A1 RID: 18849 RVA: 0x00025C47 File Offset: 0x00023E47
		public unsafe GuestFoodEasterEggData m_GuestFoodEasterEggData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_m_GuestFoodEasterEggData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestFoodEasterEggData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuest.NativeFieldInfoPtr_m_GuestFoodEasterEggData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400327F RID: 12927
		private static readonly IntPtr NativeFieldInfoPtr_convGroup;

		// Token: 0x04003280 RID: 12928
		private static readonly IntPtr NativeFieldInfoPtr_fundMultiplier;

		// Token: 0x04003281 RID: 12929
		private static readonly IntPtr NativeFieldInfoPtr_likeFoodTag;

		// Token: 0x04003282 RID: 12930
		private static readonly IntPtr NativeFieldInfoPtr_likeBevTag;

		// Token: 0x04003283 RID: 12931
		private static readonly IntPtr NativeFieldInfoPtr_evaluation;

		// Token: 0x04003284 RID: 12932
		private static readonly IntPtr NativeFieldInfoPtr_isLikeAllFoodTag;

		// Token: 0x04003285 RID: 12933
		private static readonly IntPtr NativeFieldInfoPtr_isLikeAllBevTag;

		// Token: 0x04003286 RID: 12934
		private static readonly IntPtr NativeFieldInfoPtr_isChild;

		// Token: 0x04003287 RID: 12935
		private static readonly IntPtr NativeFieldInfoPtr_doNotShowInNotebook;

		// Token: 0x04003288 RID: 12936
		private static readonly IntPtr NativeFieldInfoPtr_m_GuestFoodEasterEggData;

		// Token: 0x04003289 RID: 12937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Boolean_Boolean_Boolean_Boolean_GuestFoodEasterEggData_0;

		// Token: 0x0400328A RID: 12938
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPixel_Public_Virtual_get_CharacterSpriteSetCompact_0;

		// Token: 0x0400328B RID: 12939
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_Virtual_get_LanguageBase_0;

		// Token: 0x0400328C RID: 12940
		private static readonly IntPtr NativeMethodInfoPtr_get_LikeFoodTag_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400328D RID: 12941
		private static readonly IntPtr NativeMethodInfoPtr_get_LikeBevTag_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400328E RID: 12942
		private static readonly IntPtr NativeMethodInfoPtr_get_Evaluation_Public_get_Il2CppStringArray_0;

		// Token: 0x0400328F RID: 12943
		private static readonly IntPtr NativeMethodInfoPtr_get_FundMultiplier_Public_get_Single_0;

		// Token: 0x04003290 RID: 12944
		private static readonly IntPtr NativeMethodInfoPtr_get_ConvGroupValue_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003291 RID: 12945
		private static readonly IntPtr NativeMethodInfoPtr_get_EvaluationValue_Public_get_Int32_0;

		// Token: 0x04003292 RID: 12946
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChild_Public_get_Boolean_0;

		// Token: 0x04003293 RID: 12947
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLikeAllFoodTag_Public_get_Boolean_0;

		// Token: 0x04003294 RID: 12948
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLikeAllBevTag_Public_get_Boolean_0;

		// Token: 0x04003295 RID: 12949
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotShowInNotebook_Public_get_Boolean_0;

		// Token: 0x04003296 RID: 12950
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestFoodEasterEggData_Public_get_GuestFoodEasterEggData_0;

		// Token: 0x04003297 RID: 12951
		private static readonly IntPtr NativeMethodInfoPtr_GetFundRange_Public_Virtual_Vector2Int_0;

		// Token: 0x04003298 RID: 12952
		private static readonly IntPtr NativeMethodInfoPtr_OnGetVisual_Protected_Virtual_GuestProfilePair_Int32_0;

		// Token: 0x04003299 RID: 12953
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandomConvMessage_Public_String_0;

		// Token: 0x0400329A RID: 12954
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400329B RID: 12955
		private static readonly IntPtr NativeMethodInfoPtr__GetFundRange_b__37_0_Private_Single_Single_0;

		// Token: 0x02000ACC RID: 2764
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.NormalGuest+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CE6B RID: 52843 RVA: 0x0032D9EC File Offset: 0x0032BBEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NormalGuest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr);
				NormalGuest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr, "<>9");
				NormalGuest.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr, "<>9__18_0");
				NormalGuest.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr, "<>9__40_0");
				NormalGuest.__c.NativeFieldInfoPtr___9__40_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr, "<>9__40_1");
				NormalGuest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr, 100677953);
				NormalGuest.__c.NativeMethodInfoPtr__get_LikeBevTag_b__18_0_Internal_Int32_KeyValuePair_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr, 100677954);
				NormalGuest.__c.NativeMethodInfoPtr__ToString_b__40_0_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr, 100677955);
				NormalGuest.__c.NativeMethodInfoPtr__ToString_b__40_1_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr, 100677956);
			}

			// Token: 0x0600CE6C RID: 52844 RVA: 0x0032DAB8 File Offset: 0x0032BCB8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE6D RID: 52845 RVA: 0x0032DAF4 File Offset: 0x0032BCF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191640, XrefRangeEnd = 191641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_LikeBevTag_b__18_0(KeyValuePair<int, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.__c.NativeMethodInfoPtr__get_LikeBevTag_b__18_0_Internal_Int32_KeyValuePair_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE6E RID: 52846 RVA: 0x0032DB48 File Offset: 0x0032BD48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191641, XrefRangeEnd = 191644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__40_0(string a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.__c.NativeMethodInfoPtr__ToString_b__40_0_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CE6F RID: 52847 RVA: 0x0032DBA4 File Offset: 0x0032BDA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191644, XrefRangeEnd = 191647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__40_1(string a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuest.__c.NativeMethodInfoPtr__ToString_b__40_1_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CE70 RID: 52848 RVA: 0x0006E7F3 File Offset: 0x0006C9F3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004316 RID: 17174
			// (get) Token: 0x0600CE71 RID: 52849 RVA: 0x0032DC00 File Offset: 0x0032BE00
			// (set) Token: 0x0600CE72 RID: 52850 RVA: 0x0006E7FC File Offset: 0x0006C9FC
			public unsafe static NormalGuest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004317 RID: 17175
			// (get) Token: 0x0600CE73 RID: 52851 RVA: 0x0032DC28 File Offset: 0x0032BE28
			// (set) Token: 0x0600CE74 RID: 52852 RVA: 0x0006E80E File Offset: 0x0006CA0E
			public unsafe static Func<KeyValuePair<int, string>, int> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuest.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, string>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuest.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004318 RID: 17176
			// (get) Token: 0x0600CE75 RID: 52853 RVA: 0x0032DC50 File Offset: 0x0032BE50
			// (set) Token: 0x0600CE76 RID: 52854 RVA: 0x0006E820 File Offset: 0x0006CA20
			public unsafe static Func<string, string, string> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuest.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuest.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004319 RID: 17177
			// (get) Token: 0x0600CE77 RID: 52855 RVA: 0x0032DC78 File Offset: 0x0032BE78
			// (set) Token: 0x0600CE78 RID: 52856 RVA: 0x0006E832 File Offset: 0x0006CA32
			public unsafe static Func<string, string, string> __9__40_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NormalGuest.__c.NativeFieldInfoPtr___9__40_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NormalGuest.__c.NativeFieldInfoPtr___9__40_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084D4 RID: 34004
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084D5 RID: 34005
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x040084D6 RID: 34006
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x040084D7 RID: 34007
			private static readonly IntPtr NativeFieldInfoPtr___9__40_1;

			// Token: 0x040084D8 RID: 34008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084D9 RID: 34009
			private static readonly IntPtr NativeMethodInfoPtr__get_LikeBevTag_b__18_0_Internal_Int32_KeyValuePair_2_Int32_String_0;

			// Token: 0x040084DA RID: 34010
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__40_0_Internal_String_String_String_0;

			// Token: 0x040084DB RID: 34011
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__40_1_Internal_String_String_String_0;
		}
	}
}
