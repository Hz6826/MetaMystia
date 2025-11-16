using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.GuestManagementUtility
{
	// Token: 0x020001BE RID: 446
	public class EvalulationBoxUI : DialogBoxUI
	{
		// Token: 0x0600376A RID: 14186 RVA: 0x0015CA68 File Offset: 0x0015AC68
		// Note: this type is marked as 'beforefieldinit'.
		static EvalulationBoxUI()
		{
			Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.GuestManagementUtility", "EvalulationBoxUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr);
			EvalulationBoxUI.NativeFieldInfoPtr_exBadSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "exBadSkin");
			EvalulationBoxUI.NativeFieldInfoPtr_badSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "badSkin");
			EvalulationBoxUI.NativeFieldInfoPtr_normalSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "normalSkin");
			EvalulationBoxUI.NativeFieldInfoPtr_goodSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "goodSkin");
			EvalulationBoxUI.NativeFieldInfoPtr_exGoodSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "exGoodSkin");
			EvalulationBoxUI.NativeFieldInfoPtr_box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "box");
			EvalulationBoxUI.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "handle");
			EvalulationBoxUI.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "head");
			EvalulationBoxUI.NativeFieldInfoPtr_heart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "heart");
			EvalulationBoxUI.NativeMethodInfoPtr_SetMessage_Public_IEnumerator_String_EvaluationResult_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, 100673755);
			EvalulationBoxUI.NativeMethodInfoPtr_SetSkin_Private_Void_EvaluationBoxSkin_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, 100673756);
			EvalulationBoxUI.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, 100673757);
			EvalulationBoxUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, 100673758);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x0015CB9C File Offset: 0x0015AD9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 129031, RefRangeEnd = 129033, XrefRangeStart = 129024, XrefRangeEnd = 129031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetMessage(string message, GuestGroupController.EvaluationResult evaluationType, Transform followTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evaluationType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EvalulationBoxUI.NativeMethodInfoPtr_SetMessage_Public_IEnumerator_String_EvaluationResult_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x0015CC0C File Offset: 0x0015AE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129033, XrefRangeEnd = 129038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkin(EvalulationBoxUI.EvaluationBoxSkin skin, bool shouldShowHeat = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(skin));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldShowHeat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EvalulationBoxUI.NativeMethodInfoPtr_SetSkin_Private_Void_EvaluationBoxSkin_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x0015CC64 File Offset: 0x0015AE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129038, XrefRangeEnd = 129045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EvalulationBoxUI.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x0015CCA0 File Offset: 0x0015AEA0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EvalulationBoxUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EvalulationBoxUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x0001ED84 File Offset: 0x0001CF84
		public EvalulationBoxUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x0015CCDC File Offset: 0x0015AEDC
		// (set) Token: 0x06003771 RID: 14193 RVA: 0x0001ED8D File Offset: 0x0001CF8D
		public EvalulationBoxUI.EvaluationBoxSkin exBadSkin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_exBadSkin);
				return new EvalulationBoxUI.EvaluationBoxSkin(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_exBadSkin), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x0015CD0C File Offset: 0x0015AF0C
		// (set) Token: 0x06003773 RID: 14195 RVA: 0x0001EDBB File Offset: 0x0001CFBB
		public EvalulationBoxUI.EvaluationBoxSkin badSkin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_badSkin);
				return new EvalulationBoxUI.EvaluationBoxSkin(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_badSkin), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06003774 RID: 14196 RVA: 0x0015CD3C File Offset: 0x0015AF3C
		// (set) Token: 0x06003775 RID: 14197 RVA: 0x0001EDE9 File Offset: 0x0001CFE9
		public EvalulationBoxUI.EvaluationBoxSkin normalSkin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_normalSkin);
				return new EvalulationBoxUI.EvaluationBoxSkin(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_normalSkin), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06003776 RID: 14198 RVA: 0x0015CD6C File Offset: 0x0015AF6C
		// (set) Token: 0x06003777 RID: 14199 RVA: 0x0001EE17 File Offset: 0x0001D017
		public EvalulationBoxUI.EvaluationBoxSkin goodSkin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_goodSkin);
				return new EvalulationBoxUI.EvaluationBoxSkin(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_goodSkin), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x0015CD9C File Offset: 0x0015AF9C
		// (set) Token: 0x06003779 RID: 14201 RVA: 0x0001EE45 File Offset: 0x0001D045
		public EvalulationBoxUI.EvaluationBoxSkin exGoodSkin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_exGoodSkin);
				return new EvalulationBoxUI.EvaluationBoxSkin(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_exGoodSkin), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x0015CDCC File Offset: 0x0015AFCC
		// (set) Token: 0x0600377B RID: 14203 RVA: 0x0001EE73 File Offset: 0x0001D073
		public unsafe Image box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x0600377C RID: 14204 RVA: 0x0015CDFC File Offset: 0x0015AFFC
		// (set) Token: 0x0600377D RID: 14205 RVA: 0x0001EE92 File Offset: 0x0001D092
		public unsafe Image handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x0600377E RID: 14206 RVA: 0x0015CE2C File Offset: 0x0015B02C
		// (set) Token: 0x0600377F RID: 14207 RVA: 0x0001EEB1 File Offset: 0x0001D0B1
		public unsafe Image head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x0015CE5C File Offset: 0x0015B05C
		// (set) Token: 0x06003781 RID: 14209 RVA: 0x0001EED0 File Offset: 0x0001D0D0
		public unsafe Image heart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_heart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.NativeFieldInfoPtr_heart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeFieldInfoPtr_exBadSkin;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeFieldInfoPtr_badSkin;

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeFieldInfoPtr_normalSkin;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeFieldInfoPtr_goodSkin;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeFieldInfoPtr_exGoodSkin;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeFieldInfoPtr_box;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeFieldInfoPtr_heart;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_IEnumerator_String_EvaluationResult_Transform_0;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr_SetSkin_Private_Void_EvaluationBoxSkin_Boolean_0;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200092F RID: 2351
		[Serializable]
		public sealed class EvaluationBoxSkin : ValueType
		{
			// Token: 0x0600B8A2 RID: 47266 RVA: 0x002EAD38 File Offset: 0x002E8F38
			// Note: this type is marked as 'beforefieldinit'.
			static EvaluationBoxSkin()
			{
				Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "EvaluationBoxSkin");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr);
				EvalulationBoxUI.EvaluationBoxSkin.NativeFieldInfoPtr_box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, "box");
				EvalulationBoxUI.EvaluationBoxSkin.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, "handle");
				EvalulationBoxUI.EvaluationBoxSkin.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr, "head");
			}

			// Token: 0x0600B8A3 RID: 47267 RVA: 0x00063A35 File Offset: 0x00061C35
			public EvaluationBoxSkin(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B8A4 RID: 47268 RVA: 0x00063A3E File Offset: 0x00061C3E
			public EvaluationBoxSkin() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvalulationBoxUI.EvaluationBoxSkin>.NativeClassPtr))
			{
			}

			// Token: 0x17003C7B RID: 15483
			// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x002EADA0 File Offset: 0x002E8FA0
			// (set) Token: 0x0600B8A6 RID: 47270 RVA: 0x00063A50 File Offset: 0x00061C50
			public unsafe Sprite box
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.EvaluationBoxSkin.NativeFieldInfoPtr_box);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.EvaluationBoxSkin.NativeFieldInfoPtr_box), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C7C RID: 15484
			// (get) Token: 0x0600B8A7 RID: 47271 RVA: 0x002EADD0 File Offset: 0x002E8FD0
			// (set) Token: 0x0600B8A8 RID: 47272 RVA: 0x00063A6F File Offset: 0x00061C6F
			public unsafe Sprite handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.EvaluationBoxSkin.NativeFieldInfoPtr_handle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.EvaluationBoxSkin.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C7D RID: 15485
			// (get) Token: 0x0600B8A9 RID: 47273 RVA: 0x002EAE00 File Offset: 0x002E9000
			// (set) Token: 0x0600B8AA RID: 47274 RVA: 0x00063A8E File Offset: 0x00061C8E
			public unsafe Sprite head
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.EvaluationBoxSkin.NativeFieldInfoPtr_head);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI.EvaluationBoxSkin.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400775E RID: 30558
			private static readonly IntPtr NativeFieldInfoPtr_box;

			// Token: 0x0400775F RID: 30559
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x04007760 RID: 30560
			private static readonly IntPtr NativeFieldInfoPtr_head;
		}

		// Token: 0x02000930 RID: 2352
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.EvalulationBoxUI+<SetMessage>d__9")]
		public sealed class _SetMessage_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600B8AB RID: 47275 RVA: 0x002EAE30 File Offset: 0x002E9030
			// Note: this type is marked as 'beforefieldinit'.
			static _SetMessage_d__9()
			{
				Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvalulationBoxUI>.NativeClassPtr, "<SetMessage>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr);
				EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, "<>1__state");
				EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, "<>2__current");
				EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr_evaluationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, "evaluationType");
				EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, "<>4__this");
				EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, "message");
				EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr_followTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, "followTarget");
				EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, 100673759);
				EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, 100673760);
				EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, 100673761);
				EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, 100673762);
				EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, 100673763);
				EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr, 100673764);
			}

			// Token: 0x0600B8AC RID: 47276 RVA: 0x002EAF4C File Offset: 0x002E914C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetMessage_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvalulationBoxUI._SetMessage_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8AD RID: 47277 RVA: 0x002EAF94 File Offset: 0x002E9194
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8AE RID: 47278 RVA: 0x002EAFC8 File Offset: 0x002E91C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129000, XrefRangeEnd = 129018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C84 RID: 15492
			// (get) Token: 0x0600B8AF RID: 47279 RVA: 0x002EB004 File Offset: 0x002E9204
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B8B0 RID: 47280 RVA: 0x002EB044 File Offset: 0x002E9244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129018, XrefRangeEnd = 129024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C85 RID: 15493
			// (get) Token: 0x0600B8B1 RID: 47281 RVA: 0x002EB078 File Offset: 0x002E9278
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EvalulationBoxUI._SetMessage_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B8B2 RID: 47282 RVA: 0x00063AAD File Offset: 0x00061CAD
			public _SetMessage_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C7E RID: 15486
			// (get) Token: 0x0600B8B3 RID: 47283 RVA: 0x002EB0B8 File Offset: 0x002E92B8
			// (set) Token: 0x0600B8B4 RID: 47284 RVA: 0x00063AB6 File Offset: 0x00061CB6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C7F RID: 15487
			// (get) Token: 0x0600B8B5 RID: 47285 RVA: 0x002EB0E0 File Offset: 0x002E92E0
			// (set) Token: 0x0600B8B6 RID: 47286 RVA: 0x00063AD1 File Offset: 0x00061CD1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C80 RID: 15488
			// (get) Token: 0x0600B8B7 RID: 47287 RVA: 0x002EB110 File Offset: 0x002E9310
			// (set) Token: 0x0600B8B8 RID: 47288 RVA: 0x00063AF0 File Offset: 0x00061CF0
			public unsafe GuestGroupController.EvaluationResult evaluationType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr_evaluationType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr_evaluationType)) = value;
				}
			}

			// Token: 0x17003C81 RID: 15489
			// (get) Token: 0x0600B8B9 RID: 47289 RVA: 0x002EB138 File Offset: 0x002E9338
			// (set) Token: 0x0600B8BA RID: 47290 RVA: 0x00063B0B File Offset: 0x00061D0B
			public unsafe EvalulationBoxUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EvalulationBoxUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C82 RID: 15490
			// (get) Token: 0x0600B8BB RID: 47291 RVA: 0x002EB168 File Offset: 0x002E9368
			// (set) Token: 0x0600B8BC RID: 47292 RVA: 0x00063B2A File Offset: 0x00061D2A
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C83 RID: 15491
			// (get) Token: 0x0600B8BD RID: 47293 RVA: 0x002EB190 File Offset: 0x002E9390
			// (set) Token: 0x0600B8BE RID: 47294 RVA: 0x00063B49 File Offset: 0x00061D49
			public unsafe Transform followTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr_followTarget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EvalulationBoxUI._SetMessage_d__9.NativeFieldInfoPtr_followTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007761 RID: 30561
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007762 RID: 30562
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007763 RID: 30563
			private static readonly IntPtr NativeFieldInfoPtr_evaluationType;

			// Token: 0x04007764 RID: 30564
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007765 RID: 30565
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04007766 RID: 30566
			private static readonly IntPtr NativeFieldInfoPtr_followTarget;

			// Token: 0x04007767 RID: 30567
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007768 RID: 30568
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007769 RID: 30569
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400776A RID: 30570
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400776B RID: 30571
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400776C RID: 30572
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
