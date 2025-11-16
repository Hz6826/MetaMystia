using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x0200001D RID: 29
	public class MusicGameCountDownPannel : UIPanel
	{
		// Token: 0x06000249 RID: 585 RVA: 0x000A6604 File Offset: 0x000A4804
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameCountDownPannel()
		{
			Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicGameCountDownPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr);
			MusicGameCountDownPannel.NativeFieldInfoPtr_TotalCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, "TotalCountDown");
			MusicGameCountDownPannel.NativeFieldInfoPtr_CountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, "CountDown");
			MusicGameCountDownPannel.NativeMethodInfoPtr_get_MaxCountDown_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, 100663625);
			MusicGameCountDownPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, 100663626);
			MusicGameCountDownPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, 100663627);
			MusicGameCountDownPannel.NativeMethodInfoPtr_CountDownLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, 100663628);
			MusicGameCountDownPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, 100663629);
			MusicGameCountDownPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, 100663630);
			MusicGameCountDownPannel.NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass7_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, 100663631);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000A66E8 File Offset: 0x000A48E8
		public unsafe int MaxCountDown
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20042, RefRangeEnd = 20043, XrefRangeStart = 20042, XrefRangeEnd = 20042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel.NativeMethodInfoPtr_get_MaxCountDown_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000A6724 File Offset: 0x000A4924
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameCountDownPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000A676C File Offset: 0x000A496C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20043, XrefRangeEnd = 20050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameCountDownPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000A67A8 File Offset: 0x000A49A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20050, XrefRangeEnd = 20055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CountDownLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel.NativeMethodInfoPtr_CountDownLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000A67E8 File Offset: 0x000A49E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20055, XrefRangeEnd = 20057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameCountDownPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000A6824 File Offset: 0x000A4A24
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameCountDownPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000A6860 File Offset: 0x000A4A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20057, XrefRangeEnd = 20059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_byref___c__DisplayClass7_0_PDM_0(ref MusicGameCountDownPannel.__c__DisplayClass7_0 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel.NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass7_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00003318 File Offset: 0x00001518
		public MusicGameCountDownPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000A68A4 File Offset: 0x000A4AA4
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00003321 File Offset: 0x00001521
		public unsafe int TotalCountDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel.NativeFieldInfoPtr_TotalCountDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel.NativeFieldInfoPtr_TotalCountDown)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000A68CC File Offset: 0x000A4ACC
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0000333C File Offset: 0x0000153C
		public unsafe TextMeshProUGUI CountDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel.NativeFieldInfoPtr_CountDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel.NativeFieldInfoPtr_CountDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_TotalCountDown;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_CountDown;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCountDown_Public_get_Int32_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_CountDownLoop_Private_IEnumerator_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass7_0_PDM_0;

		// Token: 0x02000488 RID: 1160
		[ObfuscatedName("MusicGame.UI.MusicGameCountDownPannel+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : ValueType
		{
			// Token: 0x06007D48 RID: 32072 RVA: 0x0023D214 File Offset: 0x0023B414
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<MusicGameCountDownPannel.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameCountDownPannel.__c__DisplayClass7_0>.NativeClassPtr);
				MusicGameCountDownPannel.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameCountDownPannel.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				MusicGameCountDownPannel.__c__DisplayClass7_0.NativeFieldInfoPtr_currentCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameCountDownPannel.__c__DisplayClass7_0>.NativeClassPtr, "currentCountDown");
			}

			// Token: 0x06007D49 RID: 32073 RVA: 0x000437B4 File Offset: 0x000419B4
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007D4A RID: 32074 RVA: 0x000437BD File Offset: 0x000419BD
			public __c__DisplayClass7_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameCountDownPannel.__c__DisplayClass7_0>.NativeClassPtr))
			{
			}

			// Token: 0x17002A66 RID: 10854
			// (get) Token: 0x06007D4B RID: 32075 RVA: 0x0023D268 File Offset: 0x0023B468
			// (set) Token: 0x06007D4C RID: 32076 RVA: 0x000437CF File Offset: 0x000419CF
			public unsafe MusicGameCountDownPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameCountDownPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A67 RID: 10855
			// (get) Token: 0x06007D4D RID: 32077 RVA: 0x0023D298 File Offset: 0x0023B498
			// (set) Token: 0x06007D4E RID: 32078 RVA: 0x000437EE File Offset: 0x000419EE
			public unsafe int currentCountDown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel.__c__DisplayClass7_0.NativeFieldInfoPtr_currentCountDown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel.__c__DisplayClass7_0.NativeFieldInfoPtr_currentCountDown)) = value;
				}
			}

			// Token: 0x04005269 RID: 21097
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400526A RID: 21098
			private static readonly IntPtr NativeFieldInfoPtr_currentCountDown;
		}

		// Token: 0x02000489 RID: 1161
		[ObfuscatedName("MusicGame.UI.MusicGameCountDownPannel+<CountDownLoop>d__7")]
		public sealed class _CountDownLoop_d__7 : Il2CppSystem.Object
		{
			// Token: 0x06007D4F RID: 32079 RVA: 0x0023D2C0 File Offset: 0x0023B4C0
			// Note: this type is marked as 'beforefieldinit'.
			static _CountDownLoop_d__7()
			{
				Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameCountDownPannel>.NativeClassPtr, "<CountDownLoop>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr);
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, "<>1__state");
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, "<>2__current");
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, "<>4__this");
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, "<>8__1");
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr__yieldInstruction_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, "<yieldInstruction>5__2");
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, 100663632);
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, 100663633);
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, 100663634);
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, 100663635);
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, 100663636);
				MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr, 100663637);
			}

			// Token: 0x06007D50 RID: 32080 RVA: 0x0023D3C8 File Offset: 0x0023B5C8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CountDownLoop_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameCountDownPannel._CountDownLoop_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D51 RID: 32081 RVA: 0x0023D410 File Offset: 0x0023B610
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D52 RID: 32082 RVA: 0x0023D444 File Offset: 0x0023B644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20033, XrefRangeEnd = 20036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002A6D RID: 10861
			// (get) Token: 0x06007D53 RID: 32083 RVA: 0x0023D480 File Offset: 0x0023B680
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007D54 RID: 32084 RVA: 0x0023D4C0 File Offset: 0x0023B6C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20036, XrefRangeEnd = 20042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002A6E RID: 10862
			// (get) Token: 0x06007D55 RID: 32085 RVA: 0x0023D4F4 File Offset: 0x0023B6F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameCountDownPannel._CountDownLoop_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007D56 RID: 32086 RVA: 0x00043809 File Offset: 0x00041A09
			public _CountDownLoop_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A68 RID: 10856
			// (get) Token: 0x06007D57 RID: 32087 RVA: 0x0023D534 File Offset: 0x0023B734
			// (set) Token: 0x06007D58 RID: 32088 RVA: 0x00043812 File Offset: 0x00041A12
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002A69 RID: 10857
			// (get) Token: 0x06007D59 RID: 32089 RVA: 0x0023D55C File Offset: 0x0023B75C
			// (set) Token: 0x06007D5A RID: 32090 RVA: 0x0004382D File Offset: 0x00041A2D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A6A RID: 10858
			// (get) Token: 0x06007D5B RID: 32091 RVA: 0x0023D58C File Offset: 0x0023B78C
			// (set) Token: 0x06007D5C RID: 32092 RVA: 0x0004384C File Offset: 0x00041A4C
			public unsafe MusicGameCountDownPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameCountDownPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A6B RID: 10859
			// (get) Token: 0x06007D5D RID: 32093 RVA: 0x0023D5BC File Offset: 0x0023B7BC
			// (set) Token: 0x06007D5E RID: 32094 RVA: 0x0004386B File Offset: 0x00041A6B
			public MusicGameCountDownPannel.__c__DisplayClass7_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___8__1);
					return new MusicGameCountDownPannel.__c__DisplayClass7_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicGameCountDownPannel.__c__DisplayClass7_0>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr___8__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicGameCountDownPannel.__c__DisplayClass7_0>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002A6C RID: 10860
			// (get) Token: 0x06007D5F RID: 32095 RVA: 0x0023D5EC File Offset: 0x0023B7EC
			// (set) Token: 0x06007D60 RID: 32096 RVA: 0x00043899 File Offset: 0x00041A99
			public unsafe WaitForSecondsRealtime _yieldInstruction_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr__yieldInstruction_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameCountDownPannel._CountDownLoop_d__7.NativeFieldInfoPtr__yieldInstruction_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400526B RID: 21099
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400526C RID: 21100
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400526D RID: 21101
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400526E RID: 21102
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400526F RID: 21103
			private static readonly IntPtr NativeFieldInfoPtr__yieldInstruction_5__2;

			// Token: 0x04005270 RID: 21104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005271 RID: 21105
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005272 RID: 21106
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005273 RID: 21107
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005274 RID: 21108
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005275 RID: 21109
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
