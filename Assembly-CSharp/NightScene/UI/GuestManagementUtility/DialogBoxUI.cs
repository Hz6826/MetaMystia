using System;
using Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;

namespace NightScene.UI.GuestManagementUtility
{
	// Token: 0x020001BD RID: 445
	public class DialogBoxUI : MonoBehaviour
	{
		// Token: 0x06003758 RID: 14168 RVA: 0x0015C6CC File Offset: 0x0015A8CC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogBoxUI()
		{
			Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.GuestManagementUtility", "DialogBoxUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr);
			DialogBoxUI.NativeFieldInfoPtr_DIALOG_BOX_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, "DIALOG_BOX_OFFSET");
			DialogBoxUI.NativeFieldInfoPtr_DIALOG_BOX_SHOW_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, "DIALOG_BOX_SHOW_DURATION");
			DialogBoxUI.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, "text");
			DialogBoxUI.NativeFieldInfoPtr_m_WorldSpaceUITracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, "m_WorldSpaceUITracker");
			DialogBoxUI.NativeFieldInfoPtr_m_CancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, "m_CancellationTokenSource");
			DialogBoxUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, 100673744);
			DialogBoxUI.NativeMethodInfoPtr_SetMessage_Public_IEnumerator_String_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, 100673745);
			DialogBoxUI.NativeMethodInfoPtr_SetMessageAsync_Public_UniTask_String_Transform_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, 100673746);
			DialogBoxUI.NativeMethodInfoPtr_Interrupt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, 100673747);
			DialogBoxUI.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, 100673748);
			DialogBoxUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, 100673749);
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x0015C7D8 File Offset: 0x0015A9D8
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x0015C80C File Offset: 0x0015AA0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 128976, RefRangeEnd = 128978, XrefRangeStart = 128968, XrefRangeEnd = 128976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetMessage(string message, Transform followTarget, float overrideShowDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followTarget);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideShowDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI.NativeMethodInfoPtr_SetMessage_Public_IEnumerator_String_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x0015C87C File Offset: 0x0015AA7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 128997, RefRangeEnd = 128999, XrefRangeStart = 128978, XrefRangeEnd = 128997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask SetMessageAsync(string message, Transform followTarget, bool waitUntilFadeOutFinish, float overrideShowDuration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followTarget);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitUntilFadeOutFinish;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideShowDuration;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI.NativeMethodInfoPtr_SetMessageAsync_Public_UniTask_String_Transform_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x0015C8F4 File Offset: 0x0015AAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128999, XrefRangeEnd = 129000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI.NativeMethodInfoPtr_Interrupt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x0015C928 File Offset: 0x0015AB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogBoxUI.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x0015C964 File Offset: 0x0015AB64
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogBoxUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x0001ED02 File Offset: 0x0001CF02
		public DialogBoxUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06003760 RID: 14176 RVA: 0x0015C9A0 File Offset: 0x0015ABA0
		// (set) Token: 0x06003761 RID: 14177 RVA: 0x0001ED0B File Offset: 0x0001CF0B
		public unsafe static float DIALOG_BOX_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogBoxUI.NativeFieldInfoPtr_DIALOG_BOX_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogBoxUI.NativeFieldInfoPtr_DIALOG_BOX_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06003762 RID: 14178 RVA: 0x0015C9BC File Offset: 0x0015ABBC
		// (set) Token: 0x06003763 RID: 14179 RVA: 0x0001ED19 File Offset: 0x0001CF19
		public unsafe static float DIALOG_BOX_SHOW_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogBoxUI.NativeFieldInfoPtr_DIALOG_BOX_SHOW_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogBoxUI.NativeFieldInfoPtr_DIALOG_BOX_SHOW_DURATION, (void*)(&value));
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06003764 RID: 14180 RVA: 0x0015C9D8 File Offset: 0x0015ABD8
		// (set) Token: 0x06003765 RID: 14181 RVA: 0x0001ED27 File Offset: 0x0001CF27
		public unsafe TextMeshProUGUI text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06003766 RID: 14182 RVA: 0x0015CA08 File Offset: 0x0015AC08
		// (set) Token: 0x06003767 RID: 14183 RVA: 0x0001ED46 File Offset: 0x0001CF46
		public unsafe WorldSpaceUITracker m_WorldSpaceUITracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.NativeFieldInfoPtr_m_WorldSpaceUITracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldSpaceUITracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.NativeFieldInfoPtr_m_WorldSpaceUITracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06003768 RID: 14184 RVA: 0x0015CA38 File Offset: 0x0015AC38
		// (set) Token: 0x06003769 RID: 14185 RVA: 0x0001ED65 File Offset: 0x0001CF65
		public unsafe CancellationTokenSource m_CancellationTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.NativeFieldInfoPtr_m_CancellationTokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.NativeFieldInfoPtr_m_CancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeFieldInfoPtr_DIALOG_BOX_OFFSET;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeFieldInfoPtr_DIALOG_BOX_SHOW_DURATION;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldSpaceUITracker;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeFieldInfoPtr_m_CancellationTokenSource;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_IEnumerator_String_Transform_Single_0;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageAsync_Public_UniTask_String_Transform_Boolean_Single_0;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Void_0;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200092D RID: 2349
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.DialogBoxUI+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B882 RID: 47234 RVA: 0x002EA87C File Offset: 0x002E8A7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DialogBoxUI.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogBoxUI.__c__DisplayClass7_0>.NativeClassPtr);
				DialogBoxUI.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				DialogBoxUI.__c__DisplayClass7_0.NativeFieldInfoPtr_thisTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI.__c__DisplayClass7_0>.NativeClassPtr, "thisTarget");
				DialogBoxUI.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI.__c__DisplayClass7_0>.NativeClassPtr, 100673750);
				DialogBoxUI.__c__DisplayClass7_0.NativeMethodInfoPtr__SetMessageAsync_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI.__c__DisplayClass7_0>.NativeClassPtr, 100673751);
				DialogBoxUI.__c__DisplayClass7_0.NativeMethodInfoPtr__SetMessageAsync_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI.__c__DisplayClass7_0>.NativeClassPtr, 100673752);
			}

			// Token: 0x0600B883 RID: 47235 RVA: 0x002EA90C File Offset: 0x002E8B0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogBoxUI.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B884 RID: 47236 RVA: 0x002EA948 File Offset: 0x002E8B48
			[CallerCount(0)]
			public unsafe bool _SetMessageAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI.__c__DisplayClass7_0.NativeMethodInfoPtr__SetMessageAsync_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B885 RID: 47237 RVA: 0x002EA984 File Offset: 0x002E8B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128883, XrefRangeEnd = 128935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetMessageAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI.__c__DisplayClass7_0.NativeMethodInfoPtr__SetMessageAsync_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B886 RID: 47238 RVA: 0x0006389B File Offset: 0x00061A9B
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C70 RID: 15472
			// (get) Token: 0x0600B887 RID: 47239 RVA: 0x002EA9C0 File Offset: 0x002E8BC0
			// (set) Token: 0x0600B888 RID: 47240 RVA: 0x000638A4 File Offset: 0x00061AA4
			public unsafe DialogBoxUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogBoxUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C71 RID: 15473
			// (get) Token: 0x0600B889 RID: 47241 RVA: 0x002EA9F0 File Offset: 0x002E8BF0
			// (set) Token: 0x0600B88A RID: 47242 RVA: 0x000638C3 File Offset: 0x00061AC3
			public unsafe Transform thisTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.__c__DisplayClass7_0.NativeFieldInfoPtr_thisTarget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI.__c__DisplayClass7_0.NativeFieldInfoPtr_thisTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400774E RID: 30542
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400774F RID: 30543
			private static readonly IntPtr NativeFieldInfoPtr_thisTarget;

			// Token: 0x04007750 RID: 30544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007751 RID: 30545
			private static readonly IntPtr NativeMethodInfoPtr__SetMessageAsync_b__0_Internal_Boolean_0;

			// Token: 0x04007752 RID: 30546
			private static readonly IntPtr NativeMethodInfoPtr__SetMessageAsync_b__1_Internal_Boolean_0;
		}

		// Token: 0x0200092E RID: 2350
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.DialogBoxUI+<SetMessageAsync>d__7")]
		public sealed class _SetMessageAsync_d__7 : ValueType
		{
			// Token: 0x0600B88B RID: 47243 RVA: 0x002EAA20 File Offset: 0x002E8C20
			// Note: this type is marked as 'beforefieldinit'.
			static _SetMessageAsync_d__7()
			{
				Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogBoxUI>.NativeClassPtr, "<SetMessageAsync>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr);
				DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, "<>1__state");
				DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, "<>t__builder");
				DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, "<>4__this");
				DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_followTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, "followTarget");
				DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, "message");
				DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_overrideShowDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, "overrideShowDuration");
				DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_waitUntilFadeOutFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, "waitUntilFadeOutFinish");
				DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, "<>u__1");
				DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, "<>u__2");
				DialogBoxUI._SetMessageAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, 100673753);
				DialogBoxUI._SetMessageAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr, 100673754);
			}

			// Token: 0x0600B88C RID: 47244 RVA: 0x002EAB28 File Offset: 0x002E8D28
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 128965, RefRangeEnd = 128968, XrefRangeStart = 128935, XrefRangeEnd = 128965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI._SetMessageAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B88D RID: 47245 RVA: 0x002EAB60 File Offset: 0x002E8D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogBoxUI._SetMessageAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B88E RID: 47246 RVA: 0x000638E2 File Offset: 0x00061AE2
			public _SetMessageAsync_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B88F RID: 47247 RVA: 0x000638EB File Offset: 0x00061AEB
			public _SetMessageAsync_d__7() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogBoxUI._SetMessageAsync_d__7>.NativeClassPtr))
			{
			}

			// Token: 0x17003C72 RID: 15474
			// (get) Token: 0x0600B890 RID: 47248 RVA: 0x002EABA8 File Offset: 0x002E8DA8
			// (set) Token: 0x0600B891 RID: 47249 RVA: 0x000638FD File Offset: 0x00061AFD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C73 RID: 15475
			// (get) Token: 0x0600B892 RID: 47250 RVA: 0x002EABD0 File Offset: 0x002E8DD0
			// (set) Token: 0x0600B893 RID: 47251 RVA: 0x00063918 File Offset: 0x00061B18
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003C74 RID: 15476
			// (get) Token: 0x0600B894 RID: 47252 RVA: 0x002EAC00 File Offset: 0x002E8E00
			// (set) Token: 0x0600B895 RID: 47253 RVA: 0x00063946 File Offset: 0x00061B46
			public unsafe DialogBoxUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogBoxUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C75 RID: 15477
			// (get) Token: 0x0600B896 RID: 47254 RVA: 0x002EAC30 File Offset: 0x002E8E30
			// (set) Token: 0x0600B897 RID: 47255 RVA: 0x00063965 File Offset: 0x00061B65
			public unsafe Transform followTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_followTarget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_followTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C76 RID: 15478
			// (get) Token: 0x0600B898 RID: 47256 RVA: 0x002EAC60 File Offset: 0x002E8E60
			// (set) Token: 0x0600B899 RID: 47257 RVA: 0x00063984 File Offset: 0x00061B84
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C77 RID: 15479
			// (get) Token: 0x0600B89A RID: 47258 RVA: 0x002EAC88 File Offset: 0x002E8E88
			// (set) Token: 0x0600B89B RID: 47259 RVA: 0x000639A3 File Offset: 0x00061BA3
			public unsafe float overrideShowDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_overrideShowDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_overrideShowDuration)) = value;
				}
			}

			// Token: 0x17003C78 RID: 15480
			// (get) Token: 0x0600B89C RID: 47260 RVA: 0x002EACB0 File Offset: 0x002E8EB0
			// (set) Token: 0x0600B89D RID: 47261 RVA: 0x000639BE File Offset: 0x00061BBE
			public unsafe bool waitUntilFadeOutFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_waitUntilFadeOutFinish);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr_waitUntilFadeOutFinish)) = value;
				}
			}

			// Token: 0x17003C79 RID: 15481
			// (get) Token: 0x0600B89E RID: 47262 RVA: 0x002EACD8 File Offset: 0x002E8ED8
			// (set) Token: 0x0600B89F RID: 47263 RVA: 0x000639D9 File Offset: 0x00061BD9
			public UniTask<int>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___u__1);
					return new UniTask<int>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003C7A RID: 15482
			// (get) Token: 0x0600B8A0 RID: 47264 RVA: 0x002EAD08 File Offset: 0x002E8F08
			// (set) Token: 0x0600B8A1 RID: 47265 RVA: 0x00063A07 File Offset: 0x00061C07
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogBoxUI._SetMessageAsync_d__7.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007753 RID: 30547
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007754 RID: 30548
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04007755 RID: 30549
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007756 RID: 30550
			private static readonly IntPtr NativeFieldInfoPtr_followTarget;

			// Token: 0x04007757 RID: 30551
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04007758 RID: 30552
			private static readonly IntPtr NativeFieldInfoPtr_overrideShowDuration;

			// Token: 0x04007759 RID: 30553
			private static readonly IntPtr NativeFieldInfoPtr_waitUntilFadeOutFinish;

			// Token: 0x0400775A RID: 30554
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400775B RID: 30555
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400775C RID: 30556
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400775D RID: 30557
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
